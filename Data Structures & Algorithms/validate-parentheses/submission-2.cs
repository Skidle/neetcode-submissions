// using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();

        // if (s.Length % 2 != 0) {
        //     return false;
        // } 

        bool result = true;

        foreach (char bracket in s) {
            if (bracket == '(' || bracket == '{' || bracket == '[') {
                brackets.Push(bracket);
            } else {
                char prevBracket = brackets.Peek();

                if (prevBracket == '(') {
                    if (bracket == ')') {
                        brackets.Pop();
                    } else {
                        result = false;
                        break;
                    }
                } else if (prevBracket == '{') {
                    if (bracket == '}') {
                        brackets.Pop();
                    } else {
                        result = false;
                        break;
                    }
                } else if (prevBracket == '[') {
                    if (bracket == ']') {
                        brackets.Pop();
                    } else {
                        result = false;
                        break;
                    }
                } else {
                    result = false;
                    break;
                }
            }
        }

        return result;
    }
}
