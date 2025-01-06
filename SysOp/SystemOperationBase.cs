using Broker.Broker;
using Common.Domain;

namespace SysOp
{
    public abstract class SystemOperationBase
    {
        protected IBroker<IEntity> broker;

        public SystemOperationBase()
        {
            broker = new GenericBroker();
        }

        public void Execute()
        {
            try
            {
                ExecuteConcreteOperation();
                broker.Commit();
            }
            catch (Exception ex)
            {
                broker.Rollback();
                throw ex;
            }
            finally
            {
                broker.Close();
            }
        }

        protected abstract void ExecuteConcreteOperation();
    }
}
