public static void RotateMatrix(int[,] input)
{
    int matrixLength = input.GetLength(0);
    for (int i = 0; i < matrixLength / 2; i++)
    {
        int start = i;
        int end = matrixLength - 1 - i;
        for (int j = 0; j < end - start; j++)
        {
            //  Top
            int temp = input[start, start + j];
            //  Top = Left
            input[start, start + j] = input[end - j, start];
            //  Left = Bottom
            input[end - j, start] = input[end, end - j];
            //  Bottom = Right
            input[end, end - j] = input[start + j, end];
            //  Right = Top
            input[start + j, end] = temp;
        }
    }
}