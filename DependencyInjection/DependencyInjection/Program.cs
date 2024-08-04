// See https://aka.ms/new-console-template for more information

using DependencyInjection;

OutLookService service = new();

MailService mailService = new MailService(service);

mailService.SendMessageToUser();

