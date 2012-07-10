﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using zVirtualScenesModel;

namespace zVirtualScenes.Backup
{
    public partial class Backup
    {
        [Serializable]
        public class BackupGroup
        {
            public string Name;
            public List<int> NodeIds = new List<int>();
        }       

        public static void ExportGroupsAsyc(string PathFileName, Action<string> Callback)
        {
            List<BackupGroup> groups = new List<BackupGroup>();
            using (zvsLocalDBEntities context = new zvsLocalDBEntities())
            {
                foreach (group group in context.groups)
                {
                    BackupGroup backupGroup = new BackupGroup();
                    backupGroup.Name = group.name;

                    foreach (group_devices d in group.group_devices)
                        backupGroup.NodeIds.Add(d.device.node_id);

                    groups.Add(backupGroup);
                }               
            }

            Stream stream = null;
            try
            {
                stream = File.Open(PathFileName, FileMode.Create);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BackupGroup>));
                xmlSerializer.Serialize(stream, groups);
                stream.Close();

                Callback(string.Format("Exported {0} groups to '{1}'", groups.Count, Path.GetFileName(PathFileName)));
            }
            catch (Exception e)
            {
                Callback("Error saving " + PathFileName + ": (" + e.Message + ")");
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public static void ImportGroupsAsyn(string PathFileName, Action<string> Callback)
        {
            List<BackupGroup> groups = new List<BackupGroup>();
            int ImportedCount = 0;

            FileStream myFileStream = null;
            try
            {
                if (File.Exists(PathFileName))
                {
                    //Open the file written above and read values from it.       
                    XmlSerializer ScenesSerializer = new XmlSerializer(typeof(List<BackupGroup>));
                    myFileStream = new FileStream(PathFileName, FileMode.Open);
                    groups = (List<BackupGroup>)ScenesSerializer.Deserialize(myFileStream);                    

                    using (zvsLocalDBEntities context = new zvsLocalDBEntities())
                    {
                        foreach (BackupGroup backupGroup in groups)
                        {
                            group g = new group();
                            g.name = backupGroup.Name;

                            foreach (int NodeID in backupGroup.NodeIds) 
                            {
                                device d = context.devices.FirstOrDefault(o => o.node_id == NodeID);
                                if (d != null)
                                    g.group_devices.Add(new group_devices() { device_id = d.id });
                            }

                            context.groups.Add(g);
                            ImportedCount++;
                        }
                        context.SaveChanges();
                    }

                    Callback(string.Format("Imported {0} groups from '{1}'",ImportedCount, Path.GetFileName(PathFileName)));
                }
                else
                    Callback(string.Format("File '{0}' not found.", PathFileName));

            }
            catch (Exception e)
            {
                Callback("Error importing " + PathFileName + ": (" + e.Message + ")");
            }
            finally
            {

                if (myFileStream != null)
                    myFileStream.Close();
            }
        }
    }


}