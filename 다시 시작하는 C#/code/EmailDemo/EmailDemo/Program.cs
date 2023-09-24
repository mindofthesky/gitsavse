using FluentEmail.Core;
using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sneder = new SmtpSender(() => new SmtpClient(host: "localhost")
            {
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory, // 디렉토리 파일로 메일을 전달 eml 파일로 처리하는걸 확인 가능
                PickupDirectoryLocation = @"C:\Demos"

            }) ;


            Email.DefaultSender = sneder;

            // 이메일을 보내기 위한 선언과 처리

            var email = await Email.From(emailAddress: "codecode@code.code").To(emailAddress: "test@test.com", name: "AHN").Subject(subject: "열심히 포기하지말고해라.. 계속").Body(body: "계속그냥해")
                        .SendAsync();

            //email.ErrorMessages
        }
    }
}
