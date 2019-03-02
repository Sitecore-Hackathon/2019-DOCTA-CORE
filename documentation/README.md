# Docta Score
A module by the Docta Core team of awesomers

## Summary

**Category:** Best enhancement to the Sitecore Admin (XP) UI for Content Editors & Marketers

### Problem 

One of the biggest gaps in the Sitecore industry is in the area of rapid and affordable analytics and behavior-driven personalization enablement for customers. By and large, behavioral personalization on Sitecore sites requires customers to pay for or take on significant effort to score and/or profile their content in order to generate a viable set of analytics data. This effort isn't typically cheap or quick, and as customers often feel that other desired solution features implemented during build phases are more important, the analytics/personalization piece of projects tends to be the first chunk of work to get cut or bumped to the mythical "phase 2". This is rather disappointing for many reasons, not the least of which is the fact that some of Sitecore's greatest benefits are its personalization and analytics features. 

### Docta Score to the Rescue

Docta Score seeks to remedy this ailment with Sitecore solutions, by enabling clients to rapidly score and profile their content by leveraging Machine Learning to do the heavy lifting. With a minimal amount of one-time, rules-engine-based configuration - wherein the content author sets up mappings of key phrases to profile keys and scores - customers can leverage Docta Score to score and profile their content for them, including new content updated after the initial processing. 

### How it Works

Docta Score works by sending item textual content stored in the Content Search index (Solr, by default) to Azure Cognitive Service's Text Analytics API - more specifically the Key Phrase Extraction App - in order to retrieve the list of key phrases that occur in the item's content. These Key Phrases are passed in as arguments to the mapping rules configured by the user and processed by the Rules Engine to determine which, if any, profile keys should be scored on the item and what that score should be. 

The user-configured mapping rules enable the user to add any number of mappings for key phrases, and supports setting the number of points that a given mapping adds to the score for the specified profile key in the item's Tracking field. For example, a content author of the heart surgey section of a healthcare website could add a mapping for the key phrase "cardiology" with a score of 20 points, and separately add a mapping for the key phrase "cardio-vascular surgery" for 40 points. This flexibility gives authors the ability to control the default key phrase mappings for their content at a granular level.

*Note: it is worth mentioning that using Azure Cognitive Services is optional, and that Azure Cognitive Services is just the default. The logic for communicating with Azure Cognitive Services is in a pipeline processor that can be replaced with another that communicates with a different service, should you so choose.*

## Pre-requisites

Docta Core has no dependencies on other modules. 

## Installation

Perform the following steps to install the module:

1. Use the Sitecore Installation Wizard to install the [package](#link-to-package)
2. (Optional) Use the Sitecore Installation Wizard to install the [demo package](#link-to-demo-package)
3. (Not optional) Smile for the Docta!

## Configuration

Once you have installed the module, there is a little bit of configuration work that you'll need to do to get up and running.

### Configure Azure Cognitive Services Connection Details

In order to enable the application to connect with Azure Cognitive Services. The first thing that you will need to do is head over to [Azure Cognitive Services](https://azure.microsoft.com/en-us/services/cognitive-services/) and sign up or sign in. Once you do that, follow Azure's documentation for setting up an API key and a Text Analytics service in your region. Copy the endpoint URL and the API key to your configuration files as follows: 


```xml
<?xml version="1.0"?>
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <!-- TODO: Add in the configuration -->
  </sitecore>
</configuration>
```

### Configure Content Search

In order for Docta Score to work properly, you will need to ensure that the _content default Computed Index Field is set to persistent storage. If you are using Solr, you can do this by updating the managed-schema.xml file.  

### Setting up the Demo Site (FOR JUDGES AND THOSE LOOKING FOR A READY-TO-RUN-DEMO)

In addition to installing the Docta Score Sitecore package, be sure to also install the Demo site Sitecore package, which can be found in the same folder as the Docta Score Sitecore package. 

## Usage

There are a few steps to go through in order to use and maintain your mappings for Docta Score.

### Configuring the Mapping Rules (For Authors and Developers)

Docta Score includes a blank mapping rule out of the box, but this rule needs to be filled in before you can start letting Machine Learning do the content scoring work for you. 

Start by navigating to `/sitecore/system/Settings/Rules/Content Scoring/Rules/Map Key Phrases and Score Content` in the Content Editor. You should see the below in your window:

![Mapping Rule](images/MappingRule.png?raw=true "Mapping Rule")

Click on "Edit rule" to pull up the Rule Editor. Click on each of the yellow/blue macros to provide the desired value for each.

#### Filling in the Mapping

The first macro defines the "key phrase" of the page that you want to map against. For example, a key term of a page about heart surgery may be "cardiology" or "cardio-vascular surgery". 

The second macro defines the profile that you want to score against. Click on it and it will show you a tree with the available profiles for selection. These profiles are the top-level profiles that contain your profile keys and profile cards. 

The third macro defines the profile key that you wish to increase the score of when the mapped "key phrase" is found in the page's content. Click on it and it will show you a tree with the available profiles and under them you will find the profile keys that you can select.

The fourth and final macro defines the number of points that you wish to increase the specified profile key by when the mapped "key phrase" is found in the page's content.

Once you've filled out all of the fields, click the "OK" button to close the window and then "Save" the item.

#### Adding More Mappings

One of the great things about Docta Score is that you can add as many mappings as you want to your rule! 

In order to add a new mapping, click the "Edit rule" link to open the Rule Editor. Once open, in the right-hand pane at the top of the modal window you will see "Actions" available for selection. One of these actions will be the mapping rule, and will read "map the specific phrase of the content's key phrases...". Click on this rule action to add it to your rule, then follow the procedure outlined above in "Filling in the Mapping" to finish adding your new mapping. 

### Running Docta Score

Once your mapping rules are all set up, log into Sitecore open up the Content Editor. Navigate in the tree to the top level (root) item that you wish to score content for, and click the "Analyze" tab at the top. In the "Attributes" section of the ribbon you will see a button with a "spider-web-like" icon, named "Score Content". Click on this item to start the process. 

**IMPORTANT:** It was our intent to add a <saveItem> processor for this item, as well to eliminate the need for manual execution steps. However, given the limited time that we have during hackathon to complete our module, we decided to keep the manual execution for now, and add automated execution to our backlog. 




## Video

Please provide a video highlighing your Hackathon module submission and provide a link to the video. Either a [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
