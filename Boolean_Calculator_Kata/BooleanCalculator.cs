namespace Boolean_Calculator_Kata
{
    public class BooleanCalculator
    {
        public bool Calculate(string booleanValue)
        {
            //if (booleanValue == "(TRUE AND TRUE)")
            //{
            //    return true;
            //}

            //if (booleanValue == "(FALSE AND TRUE)")
            //{
            //    return false;
            //}

            //if (booleanValue == "(FALSE AND FALSE)")
            //{
            //    return false;
            //}
            
            if (booleanValue.IndexOf('(') > -1)
            {
                var x = booleanValue.IndexOf('(');
                var matchingParenthesisIndex = 0;
                var parenthesisCounter = 0;

                foreach (char c in booleanValue)
                {
                    

                    if (c == '(')
                    {
                        parenthesisCounter++;
                    }

                    if (c == ')')
                    {
                        parenthesisCounter--;
                    }

                    if (parenthesisCounter == 0)
                    {
                        break;
                    }

                    matchingParenthesisIndex++;
                }

                var resultString = booleanValue.Substring(x+1, matchingParenthesisIndex-1);
                var finalString = booleanValue.Replace($"({resultString})", this.Calculate(resultString).ToString());
                return this.Calculate(finalString);
            }



            if (booleanValue.Split("NOT", 2, StringSplitOptions.TrimEntries).Length > 1)
            {
                var boolResult1 = this.Calculate(booleanValue.Split("NOT", 2, StringSplitOptions.TrimEntries)[1]);
               
                return !boolResult1;
            }

            if (booleanValue.Split("OR", StringSplitOptions.TrimEntries).Length > 1)
            {
                var boolResult1 = this.Calculate(booleanValue.Split("OR", 2, StringSplitOptions.TrimEntries)[0]);
                var boolResult2 = this.Calculate(booleanValue.Split("OR", 2, StringSplitOptions.TrimEntries)[1]);

                return boolResult1 || boolResult2;
            }


            if (booleanValue.Split("AND", StringSplitOptions.TrimEntries).Length > 1)
            {
                var boolResult1 = this.Calculate(booleanValue.Split("AND", 2, StringSplitOptions.TrimEntries)[0]);
                var boolResult2 = this.Calculate(booleanValue.Split("AND", 2, StringSplitOptions.TrimEntries)[1]);

                return boolResult1 && boolResult2;
            }

            //if(booleanValue == "NOT FALSE")
            //    return true;

            bool boolResult;
            bool.TryParse(booleanValue, out boolResult);

            return boolResult;
        }
    }
}