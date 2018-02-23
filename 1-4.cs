public bool PalindromePermutation(string input)
{
    int result = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int vector = input[i] - 'a';
        result = result ^ (1 << vector);
    }
    if (result == 0)
    {
        return true;
    }
    else
    {
        return (result & (result - 1)) == 0;
    }
}