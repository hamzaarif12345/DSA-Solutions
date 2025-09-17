class FoodRatings {
public:
    unordered_map<string, vector<pair<string, int>>> m;
    FoodRatings(vector<string>& foods, vector<string>& cuisines, vector<int>& ratings) {
        for(int i =0;i<foods.size();i++){
            m[cuisines[i]].push_back({foods[i], ratings[i]});
        }
    }
    
    void changeRating(string food, int newRating) {
        for (auto& entry : m) {
            for (auto& foodRating : entry.second) {
                if (foodRating.first == food) {
                    foodRating.second = newRating;
                    return;  // Found the food, no need to continue searching
                }
            }
        }
    }
    
    string highestRated(string cuisine) {
       string high;
        int rate = INT_MIN;

        for (const auto& entry : m[cuisine]) {
            if (entry.second > rate) {
                high = entry.first;
                rate = entry.second;
            } else if (entry.second == rate) {
                high = min(high, entry.first);
            }
        }

        return high;
    }
};

/**
 * Your FoodRatings object will be instantiated and called as such:
 * FoodRatings* obj = new FoodRatings(foods, cuisines, ratings);
 * obj->changeRating(food,newRating);
 * string param_2 = obj->highestRated(cuisine);
 */