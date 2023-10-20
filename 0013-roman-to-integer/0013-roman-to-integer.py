class Solution(object):
    def romanToInt(self, s):
        """
        :type s: str
        :rtype: int
        """
        v={"I":1,
        "V":5,
        "X":10,
        "L":50,
        "C":100,
        "D":500,
        "M":1000 }
        tot=v.get(s[-1])
        i=0
        for i in reversed(range(len(s)-1)):
            if v.get(s[i]) < v.get(s[i+1]):
                tot-=v.get(s[i])
            else:
                tot+=v.get(s[i])
        return tot