using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace halconCSharp2.VHelper
{
    /// <summary>
    /// 鼠标注册事件工具类
    /// </summary>
    public class MouseEventHelper
    {
        /// <summary>
        /// 给指定的控件注册对应的鼠标事件及处理事件的方法
        /// RegistryMouseEvent 方法的作用是递归地为一个控件及其所有子控件注册指定的鼠标事件
        /// </summary>
        /// <param name="control">要注册鼠标事件的控件</param>
        /// <param name="del">事件处理程序(MouseEventHandler委托)</param>
        public static void RegistryMouseEvent(Control control, MouseEventHandler del,
            MouseEventName eventName)
        {
            if(control.Controls.Count > 0)
            {
                foreach (Control item in control.Controls)
                {
                    // 指定要注册的鼠标事件，如果有子控件，它会继续为子控件注册同样的事件
                    switch (eventName)
                    {
                        case MouseEventName.MouseDown:
                            item.MouseDown += del;
                            break;
                        case MouseEventName.MouseMove:
                            item.MouseMove += del;
                            break;
                        case MouseEventName.MouseUp:
                            item.MouseUp += del;
                            break;
                    }
                    // 递归给子当前控件对象的子控件继续注册鼠标对应事件
                    RegistryMouseEvent(item, del, eventName);
                }
            }
        }
    }

    /// <summary>
    /// 定义鼠标事件名称
    /// </summary>
    public enum MouseEventName
    {
        MouseDown,
        MouseMove,
        MouseUp
    }
}
