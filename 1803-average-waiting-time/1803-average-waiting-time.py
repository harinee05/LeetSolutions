class Solution:
    def averageWaitingTime(self, customers: List[List[int]]) -> float:
        
        t, a = customers[0][0] + customers[0][1], customers[0][1]

        for x, y in customers[1:]:
            if t > x:
                t+=y
            else:
                t=x+y
            a += t - x

        return a/len(customers)
            

