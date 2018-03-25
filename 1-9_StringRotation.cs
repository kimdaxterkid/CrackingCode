public bool StringRotation(string input1, string input2)
{
    string doubleString1 = input1 + input1;
    return IsSubstring(input2, doubleString1);
}