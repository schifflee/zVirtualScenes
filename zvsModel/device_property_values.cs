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
    
    public partial class device_property_values : INotifyPropertyChanged
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
    
    	private int _device_id;
        public int device_id {
    		get { 
    			return _device_id;
    		} 
    		set {
    			if (value != _device_id){
    				_device_id = value;
    			    NotifyPropertyChanged("device_id");
    			}
    		}
    	 }
    
    	private int _device_property_id;
        public int device_property_id {
    		get { 
    			return _device_property_id;
    		} 
    		set {
    			if (value != _device_property_id){
    				_device_property_id = value;
    			    NotifyPropertyChanged("device_property_id");
    			}
    		}
    	 }
    
    	private string _value;
        public string value {
    		get { 
    			return _value;
    		} 
    		set {
    			if (value != _value){
    				_value = value;
    			    NotifyPropertyChanged("value");
    			}
    		}
    	 }
    
    
    	private device_propertys _device_propertys;
        public virtual device_propertys device_propertys {
    		get { 
    			return _device_propertys;
    		} 
    		set {
    			if (value != _device_propertys){
    				_device_propertys = value;
    			    NotifyPropertyChanged("device_propertys");
    			}
    		}
    	 }
    
    	private device _device;
        public virtual device device {
    		get { 
    			return _device;
    		} 
    		set {
    			if (value != _device){
    				_device = value;
    			    NotifyPropertyChanged("device");
    			}
    		}
    	 }
    }
}