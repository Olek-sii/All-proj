using System;

namespace SymDraw {
    class Program {
        static void Main(string[] args) {
            FillQuad();
            Console.WriteLine();
            DrawQuad();
            Console.WriteLine();
            DrawTriangle1();
            Console.WriteLine();
            DrawTriangle2();
            Console.WriteLine();
            DrawTriangle3();
            Console.WriteLine();
            DrawTriangle4();
            Console.WriteLine();
            DrawTopPart();
            Console.WriteLine();
            DrawLeftPart();
            Console.WriteLine();
            DrawRightPart();
            Console.WriteLine();
            DrawBottomPart();
            Console.WriteLine();
            DrawDiagonals();
            Console.WriteLine();
            FillNumRect1();
            Console.WriteLine();
            FillNumRect2();
            Console.WriteLine();
            FillNumRect3();
            Console.WriteLine();
            FillNumRect4();
            Console.WriteLine();
            Console.ReadKey();
        }

        static void DrawLine(char fill, int length) {
            if (length > 0) {
                Console.Write('*');
                for (int i = 0; i < length - 2; i++) {
                    Console.Write(fill);
                }
                if (length > 1) {
                    Console.Write('*');
                }
            }
        }

        static void FillQuad() {
            for (int i = 0; i < 7; i++) {
                DrawLine('*', 7);
                Console.WriteLine();
            }
        }

        static void DrawQuad() {
            DrawLine('*', 7);
            Console.WriteLine();
            for (int i = 0; i < 5; i++) {
                DrawLine(' ', 7);
                Console.WriteLine();
            }
            DrawLine('*', 7);
            Console.WriteLine();
        }

        static void DrawTriangle1() {
            DrawLine('*', 7);
            Console.WriteLine();
            for (int i = 1; i <= 6; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(' ');
                }
                DrawLine(' ', 7 - i);
                Console.WriteLine();
            }
        }

        static void DrawTriangle2() {
            for (int i = 1; i <= 6; i++) {
                DrawLine(' ', i);
                Console.WriteLine();
            }
            DrawLine('*', 7);
            Console.WriteLine();
        }

        static void DrawTriangle3() {
            DrawLine('*', 7);
            Console.WriteLine();
            for (int i = 6; i >= 1; i--) {
                DrawLine(' ', i);
                Console.WriteLine();
            }
        }

        static void DrawTriangle4() {
            for (int i = 6; i >= 1; i--) {
                for (int j = 1; j <= i; j++) {
                    Console.Write(' ');
                }
                DrawLine(' ', 7 - i);
                Console.WriteLine();
            }
            DrawLine('*', 7);
            Console.WriteLine();
        }

        static void DrawTopPart() {
            DrawLine('*', 7);
            Console.WriteLine();
            for (int i = 1; i <= 3; i++) {
                for (int j = 0; j < i; j++) {
                    Console.Write(' ');
                }
                DrawLine(' ', 7 - 2 * i);
                Console.WriteLine();
            }
        }

        static void DrawLeftPart() {
            for (int i = -3; i <= 3; i++) {
                int j = (i < 0 ? -i : i);
                DrawLine(' ', 4-j);
                Console.WriteLine();
            }
        }

        static void DrawRightPart() {
            for (int i = -3; i <= 3; i++) {
                for (int j =(i < 0 ? i : -i); j < 4; ++j) {
                    Console.Write(' ');
                }
                DrawLine(' ', 4-Math.Abs(i));
                Console.WriteLine();
            }
        }

        static void DrawBottomPart() {
            for (int i = 3; i >= 1; i--) {
                for (int j = 0; j < i; j++) {
                    Console.Write(' ');
                }
                DrawLine(' ', 7 - 2 * i);
                Console.WriteLine();
            }
            DrawLine('*', 7);
            Console.WriteLine();
        }

        static void DrawDiagonals() {
            for (int i = 0; i < 7; i++) {
                for (int j = 0; j < 7; j++) {
                    if (i == j || i == 6 - j) {
                        Console.Write('*');
                    } else {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

        static void FillNumRect1() {
            for (int i = 1; i <= 7; i++) {
                for (int j = 0; j < 7; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void FillNumRect2() {
            for (int i = 0; i < 7; i++) {
                for (int j = 1; j <= 7; j++) {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        static void FillNumRect3() {
            for (int i = 7; i > 0; i--) {
                for (int j = 0; j < 7; j++) {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void FillNumRect4() {
            for (int i = 0; i < 7; i++) {
                for (int j = 7; j > 0; j--) {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }


    }
}
