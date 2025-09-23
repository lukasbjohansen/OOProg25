
using System.Xml;

// SHAPE A (10 stars in a single row)
//
// **********
//
for (int i = 0; i < 10; i++) {
	DrawingTool.DrawOneStar();
}
DrawingTool.StartNewLine();

// SHAPE B (5 stars in a single row, separated by spaces)
//
// * * * * * 
//
for (int i = 0; i < 5; i++) {
	DrawingTool.DrawOneStar();
	DrawingTool.DrawOneSpace();
}
DrawingTool.StartNewLine();

// SHAPE C  (10 rows of 10 stars each)
//
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
// **********
//
for (int i = 0; i < 10; i++) {
	for (int j = 0; j < 10; j++) {
		DrawingTool.DrawOneStar();
	}
	DrawingTool.StartNewLine();
}
DrawingTool.StartNewLine();

// SHAPE D (a triangle, I guess...)
//
// *
// **
// ***
// ****
// *****
// ******
// *******
// ********
// *********
// **********
//
for (int i = 1; i <= 10; i++) {
	for (int j = 0; j < 10; j++) {
		if (j < i) DrawingTool.DrawOneStar();
		else DrawingTool.DrawOneSpace();
	}
	DrawingTool.StartNewLine();
}
DrawingTool.StartNewLine();
for (int i = 0; i < 10; i++) {
	for (int j = 0; j < 10; j++) {
		if (j >= i) DrawingTool.DrawOneStar();
		else DrawingTool.DrawOneSpace();
	}
	DrawingTool.StartNewLine();
}
DrawingTool.StartNewLine();
for (int i = 9; i >= 0; i--) {
	for (int j = 0; j < 10; j++) {
		if (j >= i) DrawingTool.DrawOneStar();
		else DrawingTool.DrawOneSpace();
	}
	DrawingTool.StartNewLine();
}
DrawingTool.StartNewLine();
for (int i = 10; i > 0; i--) {
	for (int j = 0; j < 10; j++) {
		if (j < i) DrawingTool.DrawOneStar();
		else DrawingTool.DrawOneSpace();
	}
	DrawingTool.StartNewLine();
}
DrawingTool.StartNewLine();

// SHAPE E (X)
//
// *        *
//  *      * 
//   *    *   
//    *  *    
//     **     
//     **     
//    *  *    
//   *    *   
//  *      * 
// *        *
for (int i = 0; i < 32; i++) {
	for (int j = 0; j < 100; j++) {
		if (i < 10 && j < 10) {
			if (i == j || i == Math.Abs(j - 9) || i == 0 || i == 9 || j == 0 || j == 9) DrawingTool.DrawOneStar();
			else DrawingTool.DrawOneSpace();
		}
		else {
			switch (i) {
				case < 4:
					DrawingTool.DrawOneStar();
					break;
				case < 8:
					DrawingTool.DrawOneSpace();
					break;
				case < 12:
					DrawingTool.DrawOneStar();
					break;
				case < 16:
					DrawingTool.DrawOneSpace();
					break;
				case < 20:
					DrawingTool.DrawOneStar();
					break;
				case < 24:
					DrawingTool.DrawOneSpace();
					break;
				case < 28:
					DrawingTool.DrawOneStar();
					break;
				default:
					DrawingTool.DrawOneSpace();
					break;
			}
		}
		
	}
	DrawingTool.StartNewLine();
}

