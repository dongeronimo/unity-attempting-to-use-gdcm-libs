//--------------------------------------//               PowerUI////        For documentation or //    if you have any issues, visit//        powerUI.kulestar.com////    Copyright � 2013 Kulestar Ltd//          www.kulestar.com//--------------------------------------using System;using PowerUI;namespace Css.Keywords{		/// <summary>	/// Describes if an element currently is clicked on.	/// <summary>	sealed class IsActive:CssKeyword{				public override string Name{			get{				return "active";			}		}				public override SelectorMatcher GetSelectorMatcher(){			return new ActiveMatcher();		}			}		/// <summary>	/// Handles the matching process for :active.	/// </summary>		sealed class ActiveMatcher:LocalMatcher{				public override bool TryMatch(Dom.Node node){						if(node==null){				return false;			}						// First get a pointer over this element:			InputPointer pointer=null;						for(int i=0;i<InputPointer.PointerCount;i++){								pointer=InputPointer.AllRaw[i];								if(pointer.ActiveOverTarget==node){					// Great, got it!					break;				}else if(pointer.ActiveOverTarget!=null){										// Is our node one of its parents?					if(node.isParentOf(pointer.ActiveOverTarget)){						break;					}									}								pointer=null;							}									if(pointer!=null){				// True if the pointer is 'down':				return pointer.IsDown;			}						return false;					}			}	}