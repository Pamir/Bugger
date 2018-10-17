using System;
using System.Collections.Generic;

using System.Text;
using System.Threading;
using System.Runtime.ExceptionServices;
using System.Security;

namespace BuggerNetEng
{
    
    public class AllYouDoIsException
    {
        public static ReaderWriterLock SyncObj;

        public AllYouDoIsException()
        {
            SyncObj = new ReaderWriterLock();
        }

        public void EnterLock()
        {
            SyncObj.AcquireWriterLock(Timeout.Infinite);
        }
        public void LeaveLock()
        {
            SyncObj.ReleaseWriterLock();
        }

        public int Add(int a, int b)
        {
            int c = 0;

            this.EnterLock();
            try
            {
                c = NatLib.Add(a, b);
            }
            finally
            {
                this.LeaveLock();
            }            

            return c;
        }

        [HandleProcessCorruptedStateExceptions]
        [SecurityCritical]
        public int CallAddWithExceptionHandler(int a, int b)
        {
            int c = 0;
                        
            try
            {
                c = this.Add(a, b);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception happened: {0}", ex.Message);
            }
            
            return c;
        }
        
        public int CallAddWithoutExceptionHandler(int a, int b)
        {
            int c = 0;

            try
            {
                c = this.Add(a, b);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception happened: {0}", ex.Message);
            }

            return c;
        }



        public int WrapperForCallAdd(int a, int b, bool fAdd)
        {
            int c = 0;

            if (fAdd)
            {
                c = CallAddWithoutExceptionHandler(a, b);
            }
            else
            {
                c= CallAddWithExceptionHandler(a, b);
            }

            return c;

        }



    }
}
