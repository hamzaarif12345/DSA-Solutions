/*867. Transpose Matrix
Solved
Easy
Topics
Companies
Hint
Given a 2D integer array matrix, return the transpose of matrix.

The transpose of a matrix is the matrix flipped over its main diagonal, switching the matrix's row and column indices.



 

Example 1:

Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
Output: [[1,4,7],[2,5,8],[3,6,9]]
Example 2:

Input: matrix = [[1,2,3],[4,5,6]]
Output: [[1,4],[2,5],[3,6]]*/

class Solution {
public:
    vector<vector<int>> transpose(vector<vector<int>>& matrix) {
        int i1=matrix.size();
        int j1=matrix[0].size();
        vector<vector<int>> ans(j1,vector<int>(i1,0));
        for(int i=0;i<j1;i++){
            for(int j=0;j<i1;j++){
                ans[i][j]=matrix[j][i];
            }
        }return ans;
    }
};

// carefully see the use of the i1 and j1 