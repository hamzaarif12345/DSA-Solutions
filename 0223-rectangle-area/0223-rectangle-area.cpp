class Solution {
public:
    int computeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int ans=0;
        ans+= (ax2 - ax1) * (ay2 - ay1);
        ans+= (bx2 - bx1) * (by2 - by1);
        int ca=1; 
        // bool flag=false;
        // if(ax2 > bx1) {ca*=abs(ax2-bx1); flag=true; cout<< ca << " ";} 
        // else if (bx2 > ax1) {ca*=abs(bx2-ax1);  flag=true; cout<< ca << " ";}
        // if(ay2 > by2) {ca*=abs(ay2-by1); flag=true; cout<< ca << " ";}
        // else if (by2 > ay1) {ca*=abs(by2-ay1);  flag=true; cout<< ca << " ";}
        // if(flag) ans-=ca;
        bool overlap=true;
        if((ax1 < bx1) and (ax2 < bx1) ||(bx1 < ax1) and (bx2 < ax1)) overlap=false;
        if((ay1 < by1) and (ay2 < by1) ||(by1 < ay1) and (by2 < ay1)) overlap=false;
        vector<int> x = {ax1, ax2, bx1, bx2};
        vector<int> y = {by1, by2, ay1, ay2};
        sort(x.begin(),x.end()); 
        sort(y.begin(),y.end()); 
        if(overlap) ans-=((x[2]-x[1]) * (y[2] - y[1]));
        return ans;

    }
};