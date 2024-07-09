class Solution:
    def averageWaitingTime(self, customers: List[List[int]]) -> float:
        
        t, a = customers[0][0] + customers[0][1], customers[0][1]

        for x in customers[1:]:
            # t = max(t, x[0]) + x[1]
            if t > x[0]:
                t+=x[1]
            else:
                t=x[0]+x[1]
            a += t - x[0]

        return a/len(customers)
            

