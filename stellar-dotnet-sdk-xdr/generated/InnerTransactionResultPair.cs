// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;
namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================
    //  struct InnerTransactionResultPair
    //  {
    //      Hash transactionHash;          // hash of the inner transaction
    //      InnerTransactionResult result; // result for the inner transaction
    //  };
    //  ===========================================================================
    public class InnerTransactionResultPair
    {
        public InnerTransactionResultPair() { }
        public Hash TransactionHash { get; set; }
        public InnerTransactionResult Result { get; set; }

        public static void Encode(XdrDataOutputStream stream, InnerTransactionResultPair encodedInnerTransactionResultPair)
        {
            Hash.Encode(stream, encodedInnerTransactionResultPair.TransactionHash);
            InnerTransactionResult.Encode(stream, encodedInnerTransactionResultPair.Result);
        }
        public static InnerTransactionResultPair Decode(XdrDataInputStream stream)
        {
            InnerTransactionResultPair decodedInnerTransactionResultPair = new InnerTransactionResultPair();
            decodedInnerTransactionResultPair.TransactionHash = Hash.Decode(stream);
            decodedInnerTransactionResultPair.Result = InnerTransactionResult.Decode(stream);
            return decodedInnerTransactionResultPair;
        }
    }
}
