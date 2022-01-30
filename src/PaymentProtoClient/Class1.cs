using System;
using Payment;

namespace PaymentProtoClient
{
    internal class Consumer
    {
        public void CLientApplication()
        {
            /// 
            // Channel and client need to be implemented in the client app
            // Grpc.AspNetCore package is not compatible with netstandard2.1
            ///

            // using var channel = GrpcChannel.ForAddress("https://localhost:5001");

            // var client =  new InitiateTransaction.InitiateTransactionClient(channel);

            // var resonse = client.Create(new TransactionMessage
            // {
            //     TransactionId = Guid.NewGuid().ToString(),
            //     Description = "test description"
            // });
        }
    }
}