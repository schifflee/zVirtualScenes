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
    
    public partial class group : INotifyPropertyChanged
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
    
        public group()
        {
            this.group_devices = new ObservableCollection<group_devices>();
        }
    
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
    
    	private string _name;
        public string name {
    		get { 
    			return _name;
    		} 
    		set {
    			if (value != _name){
    				_name = value;
    			    NotifyPropertyChanged("name");
    			}
    		}
    	 }
    
    
    	private ObservableCollection<group_devices> _group_devices;
        public virtual ObservableCollection<group_devices> group_devices {
    		get { 
    			return _group_devices;
    		} 
    		set {
    			if (value != _group_devices){
    				_group_devices = value;
    			    NotifyPropertyChanged("group_devices");
    			}
    		}
    	 }
    }
}