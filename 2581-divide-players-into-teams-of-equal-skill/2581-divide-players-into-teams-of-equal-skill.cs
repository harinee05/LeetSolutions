public class Solution {
    public long DividePlayers(int[] skill) {
        Array.Sort(skill);
        
        long totChem = 0;
        int targetSkill = skill[0]+skill[skill.Length-1];
        for(int i=0;i<skill.Length/2;i++){
            if(skill[i]+skill[skill.Length-i-1] != targetSkill)
                {
                    return -1;
                }
                totChem += (long)skill[i]*(long)skill[skill.Length-i-1];
        }
        return totChem;
    }
}