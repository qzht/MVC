using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcApplication1.Models
{
    [TableAttribute("NewsEntity")]//这行很重要，因为mvc框架默认去db中找类名复数的表名
    public class NewsEntity
    {
        [Key]//设置主键
        public int NId { get; set; }

        [StringLength(100)]//设置验证信息
        [Required(ErrorMessage = "标题不能为空")]
        [DisplayName("标题")]
        public string Title { get; set; }


        [Required(ErrorMessage = "正文必须填写")]
        [DisplayName("正文")]
        public string Information { get; set; }

        public DateTime Time { get; set; }
    }
}