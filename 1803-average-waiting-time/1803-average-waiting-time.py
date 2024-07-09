class Solution:
    def averageWaitingTime(self, customers: List[List[int]]) -> float:
        
        t = customers[0][0] + customers[0][1]
        a = [customers[0][1]]

        for x in customers[1:]:
            print(t)
            print(x)
            t = max(t, x[0]) + x[1]
            a.append(t - x[0])
        print(t)
        print(a)
        return sum(a)/len(customers)
            

