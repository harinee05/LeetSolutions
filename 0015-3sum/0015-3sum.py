class Solution(object):
    def threeSum(self, nums):
        """
        :type nums: List[int]
        :rtype: List[List[int]]
        """
        nums.sort()
        p=[]
        for i in range(len(nums)):
            
            j,k=len(nums)-1,i+1
            if i>0 and nums[i]==nums[i-1]:
                continue
            while k<j:
                s=nums[i]+nums[j]+nums[k]
                if s<0:
                    k+=1
                elif s>0:
                    j-=1
                else:
                    p.append([nums[i],nums[k],nums[j]])
                    j-=1
                    k+=1
                    while(k<j and nums[k]==nums[k-1]):
                        k=k+1
                
        return p
                
                