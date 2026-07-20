// using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) {
        Stack<char> brackets = new Stack<char>();

        // if (s.Length % 2 != 0) {
        //     return false;
        // } 

        foreach (char bracket in s) {
            if (bracket == '(' || bracket == '{' || bracket == '[') {
                brackets.Push(bracket);
            } else {
                if (brackets.Count == 0) {
                    return false;
                }
                char prevBracket = brackets.Peek();

                if (prevBracket == '(') {
                    if (bracket == ')') {
                        brackets.Pop();
                    } else {
                        return false;
                    }
                } else if (prevBracket == '{') {
                    if (bracket == '}') {
                        brackets.Pop();
                    } else {
                        return false;
                    }
                } else if (prevBracket == '[') {
                    if (bracket == ']') {
                        brackets.Pop();
                    } else {
                        return false;
                    }
                } else {
                    return false;
                }
            }
        }

        if (brackets.Count == 0) {
            return true;
        }

        return false;
    }
}
