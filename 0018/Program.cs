//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// - (x+y) = -x * -y


bool TrueFalse (int x, int y)
{
    int left = -1 * (x + y);
    int right = -1 *x * (-1 * y);
    return(left == right);
}

for (int i = 0; i <= 1; i++)
    for (int j = 0; j <=1; j++)
    {
        if (TrueFalse(i, j))
        {
            Console.WriteLine($"При x = {i}  и y = {j} выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно");
        }
        else
        {
            Console.WriteLine($"При x = {i}  и y = {j} выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y ложно");
        }
    }