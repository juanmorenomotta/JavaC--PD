using System;
using System.Collections;
namespace Iterator.Ejm2
{
    /// <summary>
    /// Es un ConcreteIterator
    /// </summary>
    public class AllCandidates : Iterator
    {
        private ArrayList Data;
        IEnumerator Enum;
        Candidate nextCandidate;

        public AllCandidates()
        {
            Initialize();
            Enum = Data.GetEnumerator();
        }

        private void Initialize()
        {
            /*
             * Get data from db.
             */
            FileUtil util = new FileUtil();
            Data = util.FileToArrayList("Candidates.txt");

        }

        public override bool HasNext()
        {
            nextCandidate = null;
            while (Enum.MoveNext())
            {
                Candidate tempObj = (Candidate)Enum.Current;
                nextCandidate = tempObj;
                break;
            }
            return (nextCandidate != null);
        }

        public override Object Next()
        {
            if (nextCandidate != null)
            {
                return nextCandidate;
            }
            return null;
        }
    }
}
