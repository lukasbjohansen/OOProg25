using ItemRazorV8.Models;
using ItemRazorV8.Service.Repositories.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ItemRazorV8.Pages.Orders
{
    public class EditOrderModel : PageModel
    {
        private IOrderRepository _orderRepo;
        private IItemRepository _itemRepo;

        public EditOrderModel(IOrderRepository orderRepo, IItemRepository itemRepo)
        {
            _orderRepo = orderRepo;
            _itemRepo = itemRepo;

            List<Item> selectableItems = _itemRepo.GetAll().ToList();
            ItemList = new SelectList(selectableItems, nameof(Item.Id), nameof(Item.Name));
        }

        public int OrderId => Order?.Id ?? 0;

        [BindProperty]
        public Order Order { get; set; }


        [BindProperty]
        public int ChosenItemId { get; set; }

        public SelectList ItemList { get; set; }

        public IActionResult OnGet(int id)
        {
            Order? order = _orderRepo.Read(id);
            if (order == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            Order = order;

            return Page();
        }

        public IActionResult OnPost()
        {
            return Page();
        }

        public IActionResult OnPostDecrease(int itemId)
        {
            Order? order = _orderRepo.Read(OrderId);
			if (order == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			Order = order;

			Order updOrder = CloneOrder(Order);
            OrderLine? chosenOrderLine = updOrder.GetOrderLine(itemId);

            if (chosenOrderLine != null)
            {
                chosenOrderLine.Amount--;

                if (chosenOrderLine.Amount == 0)
                    updOrder.Items.Remove(chosenOrderLine);
            }

            _orderRepo.Update(OrderId, updOrder);

			order = _orderRepo.Read(OrderId);
			if (order == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			Order = order;

			return Page();
        }

        public IActionResult OnPostIncrease(int itemId)
        {
			Order? order = _orderRepo.Read(OrderId);
			if (order == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			Order = order;

			Order updOrder = CloneOrder(Order);
            OrderLine? chosenOrderLine = updOrder.GetOrderLine(itemId);

            if (chosenOrderLine != null)
                chosenOrderLine.Amount++;
            else
            {
                Item? chosenItem = _itemRepo.Read(itemId);
				if (chosenItem == null)
					return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

				updOrder.Items.Add(new OrderLine(chosenItem, 1));
            }

            _orderRepo.Update(OrderId, updOrder);

			order = _orderRepo.Read(OrderId);
			if (order == null)
				return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

			Order = order;

			return Page();
        }

        public IActionResult OnPostAdd()
        {
            return OnPostIncrease(ChosenItemId);
        }

        private Order CloneOrder(Order order)
        {
            Order clone = new Order(order.Id, order?.Customer);
            clone.Remark = order?.Remark;
            clone.Items = new List<OrderLine>(order?.Items ?? new List<OrderLine>());

            return clone;
        }
    }
}
