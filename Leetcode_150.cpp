/*150. Evaluate Reverse Polish Notation
Solved
Medium
Topics
Companies
You are given an array of strings tokens that represents an arithmetic expression in a Reverse Polish Notation.

Evaluate the expression. Return an integer that represents the value of the expression.

Note that:

The valid operators are '+', '-', '*', and '/'.
Each operand may be an integer or another expression.
The division between two integers always truncates toward zero.
There will not be any division by zero.
The input represents a valid arithmetic expression in a reverse polish notation.
The answer and all the intermediate calculations can be represented in a 32-bit integer.
 

Example 1:

Input: tokens = ["2","1","+","3","*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: tokens = ["4","13","5","/","+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:*/

#include <vector>
#include <string>
#include <stack>

class Solution {
public:
    int evalRPN(std::vector<std::string>& tokens) {
        std::stack<int> s;

        for (const auto& token : tokens) {
            if (isOperator(token)) {
                int operand2 = s.top();
                s.pop();
                int operand1 = s.top();
                s.pop();

                if (token == "+")
                    s.push(operand1 + operand2);
                else if (token == "-")
                    s.push(operand1 - operand2);
                else if (token == "*")
                    s.push(operand1 * operand2);
                else if (token == "/")
                    s.push(operand1 / operand2);
            } else {
                s.push(std::stoi(token));
            }
        }

        return s.top();
    }

private:
    bool isOperator(const std::string& token) {
        return token == "+" || token == "-" || token == "*" || token == "/";
    }
};
