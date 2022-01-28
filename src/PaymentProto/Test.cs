using System;
using System.Threading.Tasks;
using Grpc.Core;
using Payment;

namespace PaymentProto
{
    internal class TestClass
    {
        public void Test()
        {
            var transaction = new TransactionMessage() 
            {
                TransactionId = Guid.NewGuid().ToString(),
                Description = "test description"
            };
        }
    }

    internal class TransactionService : InitiateTransaction.InitiateTransactionBase
    {
        public override Task<TransactionResponse> Create(TransactionMessage request, ServerCallContext context)
        {
            return Task.FromResult(new TransactionResponse() 
            { 
                TransactionId = Guid.NewGuid().ToString(),
                Checked = true,
                TrackId = 1,
                Auth = false,
                Fee = 0
            });
        }
    }
}
