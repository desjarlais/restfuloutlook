using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using System.Xml;

namespace RESTfulOutlook.JsonHelpers
{
    class TreeViewHelper
    {
        public static void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    string nodeName = null;
                    if (xNode.Attributes.Count > 0)
                    {
                        foreach (XmlAttribute xAtt in xNode.Attributes)
                        {
                            if (xAtt.Name == "Name")
                            {
                                nodeName = xAtt.Value + " : ";
                            }
                        }
                    }

                    if (nodeName == null)
                    {
                        nodeName = xNode.Name;
                    }

                    inTreeNode.Nodes.Add(new TreeNode(nodeName));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        public static TreeNode Json2Tree(JObject obj)
        {
            // create the parent node
            TreeNode parent = new TreeNode();
            // loop through the obj. all token should be pair<key, value>
            foreach (var token in obj)
            {
                // change the display Content of the parent
                parent.Text = token.Key.ToString();
                // create the child node
                TreeNode child = new TreeNode();
                child.Text = token.Key.ToString();
                // check if the value is of type obj recall the method
                if (token.Value.Type.ToString() == "Object")
                {
                    // child.Text = token.Key.ToString();
                    // create a new JObject using the the Token.value
                    JObject o = (JObject)token.Value;
                    // check for empty entities
                    if (o.Count > 0)
                    {
                        // recall the method, make sure to keep track of parent to name the node correctly
                        child = Json2Tree(o);
                        child.Text = parent.Text;
                    }

                    // add the child to the parentNode
                    parent.Nodes.Add(child);
                }
                // if type is of array
                else if (token.Value.Type.ToString() == "Array")
                {
                    int ix = -1;
                    // child.Text = token.Key.ToString();
                    // loop though the array
                    foreach (var itm in token.Value)
                    {
                        // check if value is an Array of objects
                        if (itm.Type.ToString() == "Object")
                        {
                            TreeNode objTN = new TreeNode();
                            // child.Text = token.Key.ToString();
                            // call back the method
                            ix++;

                            JObject o = (JObject)itm;
                            objTN = Json2Tree(o);
                            objTN.Text = token.Key.ToString() + "[" + ix + "]";
                            child.Nodes.Add(objTN);
                            // parent.Nodes.Add(child);
                        }
                        // regular array string, int, etc
                        else if (itm.Type.ToString() == "Array")
                        {
                            ix++;
                            TreeNode dataArray = new TreeNode();
                            foreach (var data in itm)
                            {
                                dataArray.Text = token.Key.ToString() + "[" + ix + "]";
                                dataArray.Nodes.Add(data.ToString());
                            }
                            child.Nodes.Add(dataArray);
                        }

                        else
                        {
                            child.Nodes.Add(itm.ToString());
                        }
                    }
                    parent.Nodes.Add(child);
                }
                else
                {
                    // if token.Value is not nested
                    // child.Text = token.Key.ToString();
                    // change the value into N/A if value == null or an empty string 
                    if (token.Value.ToString() == "")
                    {
                        child.Nodes.Add("N/A");
                    }
                    else
                    {
                        child.Nodes.Add(token.Value.ToString());

                        // check for nextLink value
                        if (child.Text.Contains("odata.nextLink"))
                        {
                            Properties.Settings.Default.NextLink = child.FirstNode.Text;
                        }
                    }
                        
                    parent.Nodes.Add(child);
                }
            }
            return parent;
        }
    }
}
