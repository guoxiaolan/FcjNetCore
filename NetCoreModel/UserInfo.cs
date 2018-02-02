﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace NetCoreModel
{
    /// <summary>
    /// The class for User  information
    /// </summary>
    public class UserInfo
    {
        public int UserID { get; set; }
        [Required(ErrorMessage = "用户名不能为空。")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "密码不能为空。")]
        public string UserPassWord { get; set; }
    }
}