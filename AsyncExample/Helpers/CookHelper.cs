using System.Threading.Tasks;

namespace AsyncExample
{
    /// <summary>
    /// A general helper we can base new workers upon.
    /// </summary>
    interface CookHelper
    {
        public Task<bool> DoTaskAsync();
        public bool DoTaskSync();
    }
}
