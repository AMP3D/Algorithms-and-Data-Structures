using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    public class BinarySearchTree
    {
        public BinarySearchTreeNode RootNode { get; set; }

        public void Insert(object data)
        {
            if(RootNode == null)
            {
                RootNode = new BinarySearchTreeNode()
                {
                    Data = data
                };
            }
            else
            {
                InsertAtBranch(RootNode, data);
            }
        }

        public BinarySearchTreeNode Search(object data)
        {
            BinarySearchTreeNode result = null;

            if(RootNode != null)
            {
                // Is the data in the root node? If not, search the branches
                result = RootNode.Data.GetHashCode() == data.GetHashCode() ? RootNode : SearchBranches(RootNode, data);
            }

            return result;
        }

        private void InsertAtBranch(BinarySearchTreeNode parentNode, object data)
        {
            // Is the data less than that of the parent's data? If yes, add to left. If no, add to right.
            bool addToLeft = data.GetHashCode() <= parentNode.Data.GetHashCode();

            // Get a handle to the relevant branch
            BinarySearchTreeNode branch = addToLeft ? parentNode.LeftChild : parentNode.RightChild;
                        
            if (branch != null)
            {
                // Recursively traverse the tree until an available slot is found
                InsertAtBranch(branch, data);
            }
            else
            {
                // Initialize new branch
                BinarySearchTreeNode newBranch = new BinarySearchTreeNode()
                {
                    Data = data
                };

                // Insert at corresponding slot
                if(addToLeft)
                {
                    parentNode.LeftChild = newBranch;
                }
                else
                {
                    parentNode.RightChild = newBranch;
                }
            }
        }    
        
        private BinarySearchTreeNode SearchBranches(BinarySearchTreeNode parentNode, object data)
        {
            // Is the data less than that of the parent's data? If yes, search left. If no, search right.
            bool searchLeft = data.GetHashCode() <= parentNode.Data.GetHashCode();            
            BinarySearchTreeNode childBranch = searchLeft ? parentNode.LeftChild : parentNode.RightChild;
            
            if(childBranch != null)
            {
                // If the data is in the child branch
                if (childBranch.Data.GetHashCode() == data.GetHashCode())
                {
                    return childBranch;
                }
                else
                {
                    // Otherwise perform a recursive search down the branches
                    return SearchBranches(childBranch, data);
                }
            }

            // Nothing found
            return null;
        }
    }
}
