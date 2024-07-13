public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
        int n = positions.Length;
        var robots = new List<(int position, int health, char direction, int index)>();

        // Combine positions, healths, and directions into a list of tuples
        for (int i = 0; i < n; i++) {
            robots.Add((positions[i], healths[i], directions[i], i));
        }

        // Sort the list by position
        robots.Sort((a, b) => a.position.CompareTo(b.position));

        var stack = new Stack<(int health, char direction, int index)>();

        for (int i = 0; i < robots.Count; i++) {
            var robot = robots[i];
            if (robot.direction == 'R') {
                stack.Push((robot.health, robot.direction, robot.index));
            } else {
                // Handle collisions with robots moving to the right
                while (stack.Count > 0 && stack.Peek().direction == 'R') {
                    var rightRobot = stack.Pop();
                    if (rightRobot.health > robot.health) {
                        rightRobot.health -= 1;
                        stack.Push(rightRobot);
                        robot.health = 0; // left robot is destroyed
                        break;
                    } else if (rightRobot.health < robot.health) {
                        robot.health -= 1;
                    } else {
                        robot.health = 0; // both robots are destroyed
                        break;
                    }
                }
                if (robot.health > 0) {
                    stack.Push((robot.health, robot.direction, robot.index));
                }
            }
        }

        // Collect the healths of the surviving robots in the order of their original indices
        var survivors = stack.ToList();
        survivors.Sort((a, b) => a.index.CompareTo(b.index));

        // Return the healths of the surviving robots
        return survivors.Select(robot => robot.health).ToList();
    }
}
