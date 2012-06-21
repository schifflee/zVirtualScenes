//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace zVirtualScenesModel
{
    
    public partial class scheduled_tasks : INotifyPropertyChanged
    {
    	public event PropertyChangedEventHandler PropertyChanged;
         protected void NotifyPropertyChanged(string name)
            {
                onBeforePropertyChanged(name);
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(name));
                }
                onAfterPropertyChanged(name);
            }
         partial void onBeforePropertyChanged(string name);
         partial void onAfterPropertyChanged(string name);
    
    
    	private int _id;
        public int id {
    		get { 
    			return _id;
    		} 
    		set {
    			if (value != _id){
    				_id = value;
    			    NotifyPropertyChanged("id");
    			}
    		}
    	 }
    
    	private Nullable<int> _SceneID;
        public Nullable<int> SceneID {
    		get { 
    			return _SceneID;
    		} 
    		set {
    			if (value != _SceneID){
    				_SceneID = value;
    			    NotifyPropertyChanged("SceneID");
    			}
    		}
    	 }
    
    	private Nullable<int> _Frequency;
        public Nullable<int> Frequency {
    		get { 
    			return _Frequency;
    		} 
    		set {
    			if (value != _Frequency){
    				_Frequency = value;
    			    NotifyPropertyChanged("Frequency");
    			}
    		}
    	 }
    
    	private string _friendly_name;
        public string friendly_name {
    		get { 
    			return _friendly_name;
    		} 
    		set {
    			if (value != _friendly_name){
    				_friendly_name = value;
    			    NotifyPropertyChanged("friendly_name");
    			}
    		}
    	 }
    
    	private bool _isEnabled;
        public bool isEnabled {
    		get { 
    			return _isEnabled;
    		} 
    		set {
    			if (value != _isEnabled){
    				_isEnabled = value;
    			    NotifyPropertyChanged("isEnabled");
    			}
    		}
    	 }
    
    	private Nullable<System.DateTime> _startTime;
        public Nullable<System.DateTime> startTime {
    		get { 
    			return _startTime;
    		} 
    		set {
    			if (value != _startTime){
    				_startTime = value;
    			    NotifyPropertyChanged("startTime");
    			}
    		}
    	 }
    
    	private Nullable<int> _sortOrder;
        public Nullable<int> sortOrder {
    		get { 
    			return _sortOrder;
    		} 
    		set {
    			if (value != _sortOrder){
    				_sortOrder = value;
    			    NotifyPropertyChanged("sortOrder");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurMonday;
        public Nullable<bool> RecurMonday {
    		get { 
    			return _RecurMonday;
    		} 
    		set {
    			if (value != _RecurMonday){
    				_RecurMonday = value;
    			    NotifyPropertyChanged("RecurMonday");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurTuesday;
        public Nullable<bool> RecurTuesday {
    		get { 
    			return _RecurTuesday;
    		} 
    		set {
    			if (value != _RecurTuesday){
    				_RecurTuesday = value;
    			    NotifyPropertyChanged("RecurTuesday");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurWednesday;
        public Nullable<bool> RecurWednesday {
    		get { 
    			return _RecurWednesday;
    		} 
    		set {
    			if (value != _RecurWednesday){
    				_RecurWednesday = value;
    			    NotifyPropertyChanged("RecurWednesday");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurThursday;
        public Nullable<bool> RecurThursday {
    		get { 
    			return _RecurThursday;
    		} 
    		set {
    			if (value != _RecurThursday){
    				_RecurThursday = value;
    			    NotifyPropertyChanged("RecurThursday");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurFriday;
        public Nullable<bool> RecurFriday {
    		get { 
    			return _RecurFriday;
    		} 
    		set {
    			if (value != _RecurFriday){
    				_RecurFriday = value;
    			    NotifyPropertyChanged("RecurFriday");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurSaturday;
        public Nullable<bool> RecurSaturday {
    		get { 
    			return _RecurSaturday;
    		} 
    		set {
    			if (value != _RecurSaturday){
    				_RecurSaturday = value;
    			    NotifyPropertyChanged("RecurSaturday");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurSunday;
        public Nullable<bool> RecurSunday {
    		get { 
    			return _RecurSunday;
    		} 
    		set {
    			if (value != _RecurSunday){
    				_RecurSunday = value;
    			    NotifyPropertyChanged("RecurSunday");
    			}
    		}
    	 }
    
    	private Nullable<int> _RecurDays;
        public Nullable<int> RecurDays {
    		get { 
    			return _RecurDays;
    		} 
    		set {
    			if (value != _RecurDays){
    				_RecurDays = value;
    			    NotifyPropertyChanged("RecurDays");
    			}
    		}
    	 }
    
    	private Nullable<int> _RecurWeeks;
        public Nullable<int> RecurWeeks {
    		get { 
    			return _RecurWeeks;
    		} 
    		set {
    			if (value != _RecurWeeks){
    				_RecurWeeks = value;
    			    NotifyPropertyChanged("RecurWeeks");
    			}
    		}
    	 }
    
    	private Nullable<int> _RecurMonth;
        public Nullable<int> RecurMonth {
    		get { 
    			return _RecurMonth;
    		} 
    		set {
    			if (value != _RecurMonth){
    				_RecurMonth = value;
    			    NotifyPropertyChanged("RecurMonth");
    			}
    		}
    	 }
    
    	private Nullable<int> _RecurDayofMonth;
        public Nullable<int> RecurDayofMonth {
    		get { 
    			return _RecurDayofMonth;
    		} 
    		set {
    			if (value != _RecurDayofMonth){
    				_RecurDayofMonth = value;
    			    NotifyPropertyChanged("RecurDayofMonth");
    			}
    		}
    	 }
    
    	private Nullable<int> _RecurSeconds;
        public Nullable<int> RecurSeconds {
    		get { 
    			return _RecurSeconds;
    		} 
    		set {
    			if (value != _RecurSeconds){
    				_RecurSeconds = value;
    			    NotifyPropertyChanged("RecurSeconds");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurEven;
        public Nullable<bool> RecurEven {
    		get { 
    			return _RecurEven;
    		} 
    		set {
    			if (value != _RecurEven){
    				_RecurEven = value;
    			    NotifyPropertyChanged("RecurEven");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay01;
        public Nullable<bool> RecurDay01 {
    		get { 
    			return _RecurDay01;
    		} 
    		set {
    			if (value != _RecurDay01){
    				_RecurDay01 = value;
    			    NotifyPropertyChanged("RecurDay01");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay02;
        public Nullable<bool> RecurDay02 {
    		get { 
    			return _RecurDay02;
    		} 
    		set {
    			if (value != _RecurDay02){
    				_RecurDay02 = value;
    			    NotifyPropertyChanged("RecurDay02");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay03;
        public Nullable<bool> RecurDay03 {
    		get { 
    			return _RecurDay03;
    		} 
    		set {
    			if (value != _RecurDay03){
    				_RecurDay03 = value;
    			    NotifyPropertyChanged("RecurDay03");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay04;
        public Nullable<bool> RecurDay04 {
    		get { 
    			return _RecurDay04;
    		} 
    		set {
    			if (value != _RecurDay04){
    				_RecurDay04 = value;
    			    NotifyPropertyChanged("RecurDay04");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay05;
        public Nullable<bool> RecurDay05 {
    		get { 
    			return _RecurDay05;
    		} 
    		set {
    			if (value != _RecurDay05){
    				_RecurDay05 = value;
    			    NotifyPropertyChanged("RecurDay05");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay06;
        public Nullable<bool> RecurDay06 {
    		get { 
    			return _RecurDay06;
    		} 
    		set {
    			if (value != _RecurDay06){
    				_RecurDay06 = value;
    			    NotifyPropertyChanged("RecurDay06");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay07;
        public Nullable<bool> RecurDay07 {
    		get { 
    			return _RecurDay07;
    		} 
    		set {
    			if (value != _RecurDay07){
    				_RecurDay07 = value;
    			    NotifyPropertyChanged("RecurDay07");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay08;
        public Nullable<bool> RecurDay08 {
    		get { 
    			return _RecurDay08;
    		} 
    		set {
    			if (value != _RecurDay08){
    				_RecurDay08 = value;
    			    NotifyPropertyChanged("RecurDay08");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay09;
        public Nullable<bool> RecurDay09 {
    		get { 
    			return _RecurDay09;
    		} 
    		set {
    			if (value != _RecurDay09){
    				_RecurDay09 = value;
    			    NotifyPropertyChanged("RecurDay09");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay10;
        public Nullable<bool> RecurDay10 {
    		get { 
    			return _RecurDay10;
    		} 
    		set {
    			if (value != _RecurDay10){
    				_RecurDay10 = value;
    			    NotifyPropertyChanged("RecurDay10");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay11;
        public Nullable<bool> RecurDay11 {
    		get { 
    			return _RecurDay11;
    		} 
    		set {
    			if (value != _RecurDay11){
    				_RecurDay11 = value;
    			    NotifyPropertyChanged("RecurDay11");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay12;
        public Nullable<bool> RecurDay12 {
    		get { 
    			return _RecurDay12;
    		} 
    		set {
    			if (value != _RecurDay12){
    				_RecurDay12 = value;
    			    NotifyPropertyChanged("RecurDay12");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay13;
        public Nullable<bool> RecurDay13 {
    		get { 
    			return _RecurDay13;
    		} 
    		set {
    			if (value != _RecurDay13){
    				_RecurDay13 = value;
    			    NotifyPropertyChanged("RecurDay13");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay14;
        public Nullable<bool> RecurDay14 {
    		get { 
    			return _RecurDay14;
    		} 
    		set {
    			if (value != _RecurDay14){
    				_RecurDay14 = value;
    			    NotifyPropertyChanged("RecurDay14");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay15;
        public Nullable<bool> RecurDay15 {
    		get { 
    			return _RecurDay15;
    		} 
    		set {
    			if (value != _RecurDay15){
    				_RecurDay15 = value;
    			    NotifyPropertyChanged("RecurDay15");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay16;
        public Nullable<bool> RecurDay16 {
    		get { 
    			return _RecurDay16;
    		} 
    		set {
    			if (value != _RecurDay16){
    				_RecurDay16 = value;
    			    NotifyPropertyChanged("RecurDay16");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay17;
        public Nullable<bool> RecurDay17 {
    		get { 
    			return _RecurDay17;
    		} 
    		set {
    			if (value != _RecurDay17){
    				_RecurDay17 = value;
    			    NotifyPropertyChanged("RecurDay17");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay18;
        public Nullable<bool> RecurDay18 {
    		get { 
    			return _RecurDay18;
    		} 
    		set {
    			if (value != _RecurDay18){
    				_RecurDay18 = value;
    			    NotifyPropertyChanged("RecurDay18");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay19;
        public Nullable<bool> RecurDay19 {
    		get { 
    			return _RecurDay19;
    		} 
    		set {
    			if (value != _RecurDay19){
    				_RecurDay19 = value;
    			    NotifyPropertyChanged("RecurDay19");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay20;
        public Nullable<bool> RecurDay20 {
    		get { 
    			return _RecurDay20;
    		} 
    		set {
    			if (value != _RecurDay20){
    				_RecurDay20 = value;
    			    NotifyPropertyChanged("RecurDay20");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay21;
        public Nullable<bool> RecurDay21 {
    		get { 
    			return _RecurDay21;
    		} 
    		set {
    			if (value != _RecurDay21){
    				_RecurDay21 = value;
    			    NotifyPropertyChanged("RecurDay21");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay22;
        public Nullable<bool> RecurDay22 {
    		get { 
    			return _RecurDay22;
    		} 
    		set {
    			if (value != _RecurDay22){
    				_RecurDay22 = value;
    			    NotifyPropertyChanged("RecurDay22");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay23;
        public Nullable<bool> RecurDay23 {
    		get { 
    			return _RecurDay23;
    		} 
    		set {
    			if (value != _RecurDay23){
    				_RecurDay23 = value;
    			    NotifyPropertyChanged("RecurDay23");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay24;
        public Nullable<bool> RecurDay24 {
    		get { 
    			return _RecurDay24;
    		} 
    		set {
    			if (value != _RecurDay24){
    				_RecurDay24 = value;
    			    NotifyPropertyChanged("RecurDay24");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay25;
        public Nullable<bool> RecurDay25 {
    		get { 
    			return _RecurDay25;
    		} 
    		set {
    			if (value != _RecurDay25){
    				_RecurDay25 = value;
    			    NotifyPropertyChanged("RecurDay25");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay26;
        public Nullable<bool> RecurDay26 {
    		get { 
    			return _RecurDay26;
    		} 
    		set {
    			if (value != _RecurDay26){
    				_RecurDay26 = value;
    			    NotifyPropertyChanged("RecurDay26");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay27;
        public Nullable<bool> RecurDay27 {
    		get { 
    			return _RecurDay27;
    		} 
    		set {
    			if (value != _RecurDay27){
    				_RecurDay27 = value;
    			    NotifyPropertyChanged("RecurDay27");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay28;
        public Nullable<bool> RecurDay28 {
    		get { 
    			return _RecurDay28;
    		} 
    		set {
    			if (value != _RecurDay28){
    				_RecurDay28 = value;
    			    NotifyPropertyChanged("RecurDay28");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay29;
        public Nullable<bool> RecurDay29 {
    		get { 
    			return _RecurDay29;
    		} 
    		set {
    			if (value != _RecurDay29){
    				_RecurDay29 = value;
    			    NotifyPropertyChanged("RecurDay29");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay30;
        public Nullable<bool> RecurDay30 {
    		get { 
    			return _RecurDay30;
    		} 
    		set {
    			if (value != _RecurDay30){
    				_RecurDay30 = value;
    			    NotifyPropertyChanged("RecurDay30");
    			}
    		}
    	 }
    
    	private Nullable<bool> _RecurDay31;
        public Nullable<bool> RecurDay31 {
    		get { 
    			return _RecurDay31;
    		} 
    		set {
    			if (value != _RecurDay31){
    				_RecurDay31 = value;
    			    NotifyPropertyChanged("RecurDay31");
    			}
    		}
    	 }
    
    
    	private scene _scene;
        public virtual scene scene {
    		get { 
    			return _scene;
    		} 
    		set {
    			if (value != _scene){
    				_scene = value;
    			    NotifyPropertyChanged("scene");
    			}
    		}
    	 }
    }
}