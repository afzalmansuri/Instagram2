import {PostBase} from '../database-models/post-base';
import {InstaUserBase} from '../database-models/insta-user-base';
import {PostTagBase} from '../database-models/post-tag-base';
import {PostCommentBase} from '../database-models/post-comment-base';
import {PostLikeBase} from '../database-models/post-like-base';
import {PostShareBase} from '../database-models/post-share-base';
//Generated Imports
export class Post extends PostBase 
{




//#region Generated Reference Properties
//#region instaUser Prop
instaUser : InstaUserBase;
//#endregion instaUser Prop
//#region postTags Prop
postTags : PostTagBase[];
//#endregion postTags Prop
//#region postComments Prop
postComments : PostCommentBase[];
//#endregion postComments Prop
//#region postLikes Prop
postLikes : PostLikeBase[];
//#endregion postLikes Prop
//#region postShares Prop
postShares : PostShareBase[];
//#endregion postShares Prop

//#endregion Generated Reference Properties

}