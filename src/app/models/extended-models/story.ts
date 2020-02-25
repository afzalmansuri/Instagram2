import {StoryBase} from '../database-models/story-base';
import {InstaUserBase} from '../database-models/insta-user-base';
import {StoryCommentBase} from '../database-models/story-comment-base';
import {StoryShareBase} from '../database-models/story-share-base';
import {StoryTagBase} from '../database-models/story-tag-base';
import {ViewStoryBase} from '../database-models/view-story-base';
//Generated Imports
export class Story extends StoryBase 
{




//#region Generated Reference Properties
//#region instaUser Prop
instaUser : InstaUserBase;
//#endregion instaUser Prop
//#region storyComments Prop
storyComments : StoryCommentBase[];
//#endregion storyComments Prop
//#region storyShares Prop
storyShares : StoryShareBase[];
//#endregion storyShares Prop
//#region storyTags Prop
storyTags : StoryTagBase[];
//#endregion storyTags Prop
//#region viewStorys Prop
viewStorys : ViewStoryBase[];
//#endregion viewStorys Prop

//#endregion Generated Reference Properties

}