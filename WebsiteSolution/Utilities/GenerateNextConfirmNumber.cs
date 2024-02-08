using Group5_FinalProject_v2.DAL;

namespace Group5_FinalProject_v2.Utilities
{
    public static class GenerateNextConfirmNumber
    {
        public static Int32 GetNextConfirmNumber(AppDbContext _context)
        {
            //set a constant to designate where the registration numbers 
            //should start
            const Int32 START_ID= 10001;

            Int32 intMaxConfirmNumber; //the current maximum order number
            Int32 intNextConfirmNumber; //the order number for the next order

            if (_context.Purchases.Count() == 0) //there are no registrations in the database yet
            {
                intMaxConfirmNumber = START_ID; //registration numbers start at 101
            }
            else
            {
                intMaxConfirmNumber = _context.Purchases.Max(o => o.PurchaseID); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxConfirmNumber < START_ID)
            {
                intMaxConfirmNumber = START_ID;
            }

            //add one to the current max to find the next one
            intNextConfirmNumber = intMaxConfirmNumber + 1;

            //return the value
            return intNextConfirmNumber;
        }

    }
}