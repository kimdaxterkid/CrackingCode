public bool OneAway(string input1, string input2)
{
    if((Math.Abs(input1.Length) - Math.Abs(input2.Length)) > 1)
    {
        return false;
    }
    else
    {
        string s1 = input1.Length < input2.Length ? input1 : input2;
        string s2 = input1.Length < input2.Length ? input2 : input1;

        int index1 = 0;
        int index2 = 0;
        bool foundDifference = false;
        while(index1 < input1.Length && index2 < input2.Length)
        {
            if(input1[index1] != input2[index2])
            {
                if(foundDifference)
                {
                    return false;
                }
                else
                {
                    foundDifference = true;
                    if(s1.Length == s2.Length)
                    {
                        index1 += 1;
                    }
                }
            } else
            {
                index1 += 1;
            }
            index2 += 1;
        }

    }
    return true;
}