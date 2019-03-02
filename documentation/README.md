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

## Pre-requisites

Docta Core has no dependencies on other modules. 

## Installation

Provide detailed instructions on how to install the module, and include screenshots where necessary.

1. Use the Sitecore Installation wizard to install the [package](#link-to-package)
2. Smile

## Configuration

How do you configure your module once it is installed? Are there items that need to be updated with settings, or maybe config files need to have keys updated?

Remember you are using Markdown, you can provide code samples too:

```xml
<?xml version="1.0"?>
<!--
  Purpose: Configuration settings for my hackathon module
-->
<configuration xmlns:patch="http://www.sitecore.net/xmlconfig/">
  <sitecore>
    <settings>
      <setting name="MyModule.Setting" value="Hackathon" />
    </settings>
  </sitecore>
</configuration>
```

## Usage

Provide documentation  about your module, how do the users use your module, where are things located, what do icons mean, are there any secret shortcuts etc.

Please include screenshots where necessary. You can add images to the `./images` folder and then link to them from your documentation:

![Hackathon Logo](images/hackathon.png?raw=true "Hackathon Logo")

You can embed images of different formats too:

![Deal With It](images/deal-with-it.gif?raw=true "Deal With It")

And you can embed external images too:

![Random](https://placeimg.com/480/240/any "Random")

## Video

Please provide a video highlighing your Hackathon module submission and provide a link to the video. Either a [direct link](https://www.youtube.com/watch?v=EpNhxW4pNKk) to the video, upload it to this documentation folder or maybe upload it to Youtube...

[![Sitecore Hackathon Video Embedding Alt Text](https://img.youtube.com/vi/EpNhxW4pNKk/0.jpg)](https://www.youtube.com/watch?v=EpNhxW4pNKk)
