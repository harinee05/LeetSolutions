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
                        stack.Push((rightRobot.health - 1, rightRobot.direction, rightRobot.index));
                        robot = (robot.position, 0, robot.direction, robot.index); // left robot is destroyed
                        break;
                    } else if (rightRobot.health < robot.health) {
                        robot = (robot.position, robot.health - 1, robot.direction, robot.index);
                    } else {
                        robot = (robot.position, 0, robot.direction, robot.index); // both robots are destroyed
                        break;
                    }
                }
                if (robot.health > 0) {
                    stack.Push((robot.health, robot.direction, robot.index));
                }
            }
        }

        // Create a list to store the healths of the surviving robots in the order of their original indices
        var result = new int[n];
        foreach (var robot in stack) {
            result[robot.index] = robot.health;
        }

        // Return a list of non-zero healths
        return result.Where(h => h > 0).ToList();
    }
}