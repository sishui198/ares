//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1022
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARES {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal class ThisAddIn {
        
        internal static string Name {
            get {
                return "ARES for ArcMap 10.0";
            }
        }
        
        internal static string AddInID {
            get {
                return "{84661142-7c89-49c1-8d6b-17bc043a46d4}";
            }
        }
        
        internal static string Company {
            get {
                return "Haoliang Yu, Xuan Wang, Jian Qing, Hancheng Nie";
            }
        }
        
        internal static string Version {
            get {
                return "0.2.1";
            }
        }
        
        internal static string Description {
            get {
                return "ArcMap Raster Edit Suite";
            }
        }
        
        internal static string Author {
            get {
                return "Haoliang Yu, Xuan Wang, Jian Qing, Hancheng Nie";
            }
        }
        
        internal static string Date {
            get {
                return "2015-4-19";
            }
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'RasterEditor_StartEditingButton', the id declared for Add-in Button class 'StartEditingButton'
            /// </summary>
            internal static string StartEditingButton {
                get {
                    return "RasterEditor_StartEditingButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_IdentifyTool', the id declared for Add-in Tool class 'IdentifyTool'
            /// </summary>
            internal static string IdentifyTool {
                get {
                    return "RasterEditor_IdentifyTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_StopEditingButton', the id declared for Add-in Button class 'StopEditingButton'
            /// </summary>
            internal static string StopEditingButton {
                get {
                    return "RasterEditor_StopEditingButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_SaveEditsButton', the id declared for Add-in Button class 'SaveEditsButton'
            /// </summary>
            internal static string SaveEditsButton {
                get {
                    return "RasterEditor_SaveEditsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_SaveEditsAsButton', the id declared for Add-in Button class 'SaveEditsAsButton'
            /// </summary>
            internal static string SaveEditsAsButton {
                get {
                    return "RasterEditor_SaveEditsAsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_ShowEditsButton', the id declared for Add-in Button class 'ShowEditsButton'
            /// </summary>
            internal static string ShowEditsButton {
                get {
                    return "RasterEditor_ShowEditsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_ClearSelectionButton', the id declared for Add-in Button class 'ClearSelectionButton'
            /// </summary>
            internal static string ClearSelectionButton {
                get {
                    return "RasterEditor_ClearSelectionButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_GoToPixelTool', the id declared for Add-in Button class 'GoToPixelTool'
            /// </summary>
            internal static string GoToPixelTool {
                get {
                    return "RasterEditor_GoToPixelTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_EditExtentButon', the id declared for Add-in Button class 'EditExtentButon'
            /// </summary>
            internal static string EditExtentButon {
                get {
                    return "RasterEditor_EditExtentButon";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_EditTool', the id declared for Add-in Tool class 'EditTool'
            /// </summary>
            internal static string EditTool {
                get {
                    return "RasterEditor_EditTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_FreeDrawTool', the id declared for Add-in Tool class 'FreeDrawTool'
            /// </summary>
            internal static string FreeDrawTool {
                get {
                    return "RasterPainter_FreeDrawTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_StartPaintingButton', the id declared for Add-in Button class 'StartPaintingButton'
            /// </summary>
            internal static string StartPaintingButton {
                get {
                    return "RasterPainter_StartPaintingButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_StopPaintingButton', the id declared for Add-in Button class 'StopPaintingButton'
            /// </summary>
            internal static string StopPaintingButton {
                get {
                    return "RasterPainter_StopPaintingButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_TestButton', the id declared for Add-in Button class 'TestButton'
            /// </summary>
            internal static string TestButton {
                get {
                    return "RasterPainter_TestButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_SavePaintsButton', the id declared for Add-in Button class 'SavePaintsButton'
            /// </summary>
            internal static string SavePaintsButton {
                get {
                    return "RasterPainter_SavePaintsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_EraseTool', the id declared for Add-in Tool class 'EraseTool'
            /// </summary>
            internal static string EraseTool {
                get {
                    return "RasterPainter_EraseTool";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_SavePaintsAsButton', the id declared for Add-in Button class 'SavePaintsAsButton'
            /// </summary>
            internal static string SavePaintsAsButton {
                get {
                    return "RasterPainter_SavePaintsAsButton";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_IdentifyForm', the id declared for Add-in DockableWindow class 'IdentifyForm+AddinImpl'
            /// </summary>
            internal static string IdentifyForm {
                get {
                    return "RasterEditor_IdentifyForm";
                }
            }
            
            /// <summary>
            /// Returns 'RasterEditor_EditForm', the id declared for Add-in DockableWindow class 'EditForm+AddinImpl'
            /// </summary>
            internal static string EditForm {
                get {
                    return "RasterEditor_EditForm";
                }
            }
            
            /// <summary>
            /// Returns 'RasterPainter_ValueSymbolForm', the id declared for Add-in DockableWindow class 'ValueSymbolForm+AddinImpl'
            /// </summary>
            internal static string ValueSymbolForm {
                get {
                    return "RasterPainter_ValueSymbolForm";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;

      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
