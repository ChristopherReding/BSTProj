using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class BinarySearchTree
    {
        //first node
        Node start = null;

        public bool CheckForRightLink(Node node)
        {
            if(node.rightLink == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CheckForLeftLink(Node node)
        {
            if (node.leftLink == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Add(int number)
        {
            Node node = new Node();
            node.data = number;
            if(start == null) //to add the level 0 the first node
            {
                start = node;
                return;
            }
                        
            Node tempNode = start;
            bool nodeHasLink = true;            
            if (number <= tempNode.data)
            {
                nodeHasLink = CheckForLeftLink(tempNode);
            }
            else if (number > tempNode.data)
            {
                nodeHasLink = CheckForRightLink(tempNode);
            }
            
            while(nodeHasLink)
            {                
                if (number <= tempNode.data)
                {                    
                    tempNode = tempNode.leftLink;                    
                }
                else if (number > tempNode.data)
                {                    
                    tempNode = tempNode.rightLink;                    
                }
                
                if (number <= tempNode.data)
                {
                    nodeHasLink = CheckForLeftLink(tempNode);
                }
                else if (number > tempNode.data)
                {
                    nodeHasLink = CheckForRightLink(tempNode);
                }
            }

            if (number <= tempNode.data)
            {
                tempNode.leftLink = node;
            }
            else if (number > tempNode.data)
            {
                tempNode.rightLink = node;
            }




        }
    }
}
