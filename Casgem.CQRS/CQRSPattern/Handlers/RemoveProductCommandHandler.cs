using Casgem.CQRS.CQRSPattern.Commands;
using Casgem.CQRS.DAL;

namespace Casgem.CQRS.CQRSPattern.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(RemoveProductCommand command)
        {
            var values = _context.Products.Find(command.RemoveProductCommandId);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}