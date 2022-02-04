using System.Threading;
using System.Threading.Tasks;

namespace CodeExamplesConsole
{
    public class FactorialCalculator
    {
        public Task<long> CalcAsync(int x, CancellationToken token)
        {
            return Task.Run(async () =>
            {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * await CalcAsync(x - 1, token);
                }
            }, token);
        }
    }
}
