// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnet_sdk.xdr
{

    // === xdr source ============================================================

    //  struct TransactionResultSet
    //  {
    //      TransactionResultPair results<>;
    //  };

    //  ===========================================================================
    public class TransactionResultSet
    {
        public TransactionResultSet() { }
        public TransactionResultPair[] Results { get; set; }

        public static void Encode(XdrDataOutputStream stream, TransactionResultSet encodedTransactionResultSet)
        {
            int resultssize = encodedTransactionResultSet.Results.Length;
            stream.WriteInt(resultssize);
            for (int i = 0; i < resultssize; i++)
            {
                TransactionResultPair.Encode(stream, encodedTransactionResultSet.Results[i]);
            }
        }
        public static TransactionResultSet Decode(XdrDataInputStream stream)
        {
            TransactionResultSet decodedTransactionResultSet = new TransactionResultSet();
            int resultssize = stream.ReadInt();
            decodedTransactionResultSet.Results = new TransactionResultPair[resultssize];
            for (int i = 0; i < resultssize; i++)
            {
                decodedTransactionResultSet.Results[i] = TransactionResultPair.Decode(stream);
            }
            return decodedTransactionResultSet;
        }
    }
}
