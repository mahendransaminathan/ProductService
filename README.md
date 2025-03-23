# Build, publish and deploy - Back End Service  
Create an Azure Subscription from portal.azure.com (if not created already)  
Follow the below steps to create Azure App Service for backend  
• Search for "App Services" and select "App Services" from Services section  
• Select Create menu option under App Services  
• Select Web App option from the drop down menu  
• Create Web App Page will be displayed  
• Select one of the subscription from available subscriptions  
• Create a new resource group by selecting "Create new" option  
• Provide a resource group name example "PLA" and click on Ok button  
• Enter Web App Name example ProductService  
• Select code Radio button for Publish option  
• Select Runtime stack as .Net 9 (STS)  
• Select Operating System as Windows  
• Select near by region for Region example "East US 2"  
• Under Pricing Plans leave default value for Windows Plan  
• Select Free F1 for pricing plan  
• Select Disabled option for Zone Redundancy  
• Click on Review + create button  
• Click on Create button from "Review + create" tab  

• Go to Azure Portal and select the ProductService app service  
• Go to Settings section from left side of the screen and select Configuration section  
• Under Default settings section, select "on" option for the following two fields  
• Under Platform settings, Select on option for SCM Basic Auth Publishing credentials  
• Select on option for FTP Basic Auth Publishing credentials  
• click on save button to save the changes  

• Click on Download publish profile option to download the publish profile from your Company Service App Service  
• Open the downloaded the publish profile and copy the content to notepad  

• Go to Settings under Back end Github repository  
• Scroll down to select Secrets and Variables under Security section on the left side of the screen  
• Select on Actions option and click on New Repository secret button.  
• Provide a name to this secret example Azure_Publish_Profile and paste the service principle from notepad  
• Click on Add Secret button  

# Creating MongoDB account
1. Create a MongoDB Account by following the steps  
2. Enter the link in the browser  https://www.mongodb.com/cloud/atlas/register  
3. Enter First Name, Last Name, Email ID & Password and click on Create your Atlas account button  
4. Your will receive an email link in your email account.  
5. Click on the link from your Email account. It will take to your MongoDB Login  
6. Enter your email ID and password to login into your MongoDB account  
7. Under Overview section, click on Create Clusters button to create a cluster
8. Deploy your cluster window will open up  
9. Select the Free tier option
10. Under Name section, enter the name for your cluster and leave the remaining fields as default    
11. Click on Create Deployment button at the bottom of the screen  
12. Select your clusters option under Database at the left side of the screen
13. Click on Browse collections option. It will take to collections tab     
14. Click on + Create Database button to create your DB  
15. Enter Database name under Database name section. Ex. ProductService    
16. Enter Collection name under collection name section. Ex. Product    
17. Select Clustered Index collection under Additional Preferences section  
18. Click on Create button to create the database  
19. Select Overview tab under your cluster  
20. Click on Connect button to copy the Connection string  
21. Connect to Cluster window pop up  
22. Under Connection string section, click on copy button and paste the connection string to your notepad    

# Create Connection string in your ProductService  
1. Go to your Product Service App Service  
2. Under settings section on the left side of the screen, Click Environment Variables section
3. Click on +Add button
4. Under Name* section, Enter the name as MONGODB_CONNECTION_STRING
5. Under the value section, copy the connection string value from your notepad and paste it here
6. Click on Apply button at the button of the screen to save the changes
   
