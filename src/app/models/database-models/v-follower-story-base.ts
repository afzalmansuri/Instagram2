import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vFollowerStoryBase {

//#region instaUserName Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'instaUserName', keyColumn: false})
        instaUserName : string;
//#endregion instaUserName Prop


//#region instaUserId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'instaUserId', keyColumn: true})
        instaUserId : number;
//#endregion instaUserId Prop


//#region storyContent Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'storyContent', keyColumn: false})
        storyContent : string;
//#endregion storyContent Prop


//#region storyDateTime Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'storyDateTime', keyColumn: false})
        storyDateTime : any;
//#endregion storyDateTime Prop


//#region followTo Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'followTo', keyColumn: false})
        followTo : number;
//#endregion followTo Prop


//#region followBy Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'followBy', keyColumn: false})
        followBy : number;
//#endregion followBy Prop

}