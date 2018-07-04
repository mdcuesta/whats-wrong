// D

namespace Sampler.Codes
{
    public interface IMessage
    {
    }

    public class EmployeeMessage : IMessage
    {
    }

    public class ClientMessage : IMessage
    {
    }


    public class DepartmentMessage : IMessage
    {
    }

    public class EmployeeMessageHandler
    {
        public void Handle(EmployeeMessage message)
        {
        }
    }

    public class ClientMessageHandler
    {
        public void Handle(ClientMessage message)
        {
        }
    }

    public class DepartmentMessageHandler
    {
        public void Handle(DepartmentMessage message)
        {
        }
    }

    public class Sample14
    {
        public void Process(IMessage message)
        {
            if (message is EmployeeMessage)
            {
                var handler = new EmployeeMessageHandler();
                handler.Handle(message as EmployeeMessage);
            }
            else if (message is ClientMessage)
            {
                var handler = new ClientMessageHandler();
                handler.Handle(message as ClientMessage);
            }
            else if (message is DepartmentMessage)
            {
                var handler = new DepartmentMessageHandler();
                handler.Handle(message as DepartmentMessage);
            }
        }

    }
}
