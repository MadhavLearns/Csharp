using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp.Event
{
    public class VideoEncoder
    {
        public delegate void VideoEncoderHandler(object source, EventArgs args);

        public event VideoEncoderHandler VideoEncoded;
        public void Encode()
        {
            Console.WriteLine("Video Encoding has started");
            Thread.Sleep(3000);

            OnVideoEncoded();

        }

        protected virtual void OnVideoEncoded()
        {
            if(VideoEncoded!= null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }

    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Mail has been sent!");
        }
    }

    public class SMSService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("SMS has been sent!");
        }
    }
}
