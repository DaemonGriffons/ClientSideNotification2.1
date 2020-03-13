using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ClientSideNotification2._1.Models;
using ClientNotifications;
using ClientNotifications.Helpers;

namespace ClientSideNotification2._1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IClientNotification _clientNotifications;

        public HomeController(IClientNotification clientNotification)
        {
            _clientNotifications = clientNotification;
        }
        public IActionResult Index()
        {
            _clientNotifications.AddToastNotification("Welcome Back", NotificationHelper.NotificationType.info, new ToastNotificationOption
            {
                NewestOnTop = true,
                CloseButton = true,
                PositionClass = "toast-bottom-right",
                PreventDuplicates = true
            });
            return View();
        }

        public IActionResult Success()
        {
            _clientNotifications.AddToastNotification("Success toast message", NotificationHelper.NotificationType.success, new ToastNotificationOption
            {
                NewestOnTop = true,
                CloseButton = true,
                PositionClass = "toast-bottom-right",
                PreventDuplicates = true
            });
            return View();
        }

        public IActionResult Error()
        {
            _clientNotifications.AddToastNotification("Error toast message", NotificationHelper.NotificationType.error, new ToastNotificationOption
            {
                NewestOnTop = true,
                CloseButton = true,
                PositionClass = "toast-bottom-right",
                PreventDuplicates = true
            });
            return View();
        }
        public IActionResult Info()
        {
            _clientNotifications.AddToastNotification("Info toast message", NotificationHelper.NotificationType.info, new ToastNotificationOption
            {
                NewestOnTop = true,
                CloseButton = true,
                PositionClass = "toast-bottom-right",
                PreventDuplicates = true
            });
            return View();
        }
        public IActionResult Warning()
        {
            _clientNotifications.AddToastNotification("Warning toast message", NotificationHelper.NotificationType.warning, new ToastNotificationOption
            {
                NewestOnTop = true,
                CloseButton = true,
                PositionClass = "toast-bottom-right",
                PreventDuplicates = true
            });
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult SweetAlertInfo()
        {
            _clientNotifications.AddSweetNotification("Information", "Information Notification from Sweet Alert", NotificationHelper.NotificationType.info);
            return View();
        }

        public IActionResult SweetAlertSuccess()
        {
            _clientNotifications.AddSweetNotification("Success", "Success Notification from Sweet Alert", NotificationHelper.NotificationType.success);
            return View();
        }
        public IActionResult SweetAlertWarning()
        {
            _clientNotifications.AddSweetNotification("Warning", "Warning Notification from Sweet Alert", NotificationHelper.NotificationType.warning);
            return View();
        }
        public IActionResult SweetAlertError()
        {
            _clientNotifications.AddSweetNotification("Error", "Error Notification from Sweet Alert", NotificationHelper.NotificationType.success);
            return View();
        }

    }
}
