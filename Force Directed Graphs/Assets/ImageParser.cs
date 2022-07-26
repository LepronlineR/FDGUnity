using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class ImageParser {
    public var items;

    public static ImageParser CreateFromJSON(string jsonString){
        return JsonUtility.FromJson<PlayerInfo>(jsonString);
    }
}
/*

{
  "kind": "customsearch#search",
  "url": {
    "type": "application/json",
    "template": "https://www.googleapis.com/customsearch/v1?q={searchTerms}&num={count?}&start={startIndex?}&lr={language?}&safe={safe?}&cx={cx?}&sort={sort?}&filter={filter?}&gl={gl?}&cr={cr?}&googlehost={googleHost?}&c2coff={disableCnTwTranslation?}&hq={hq?}&hl={hl?}&siteSearch={siteSearch?}&siteSearchFilter={siteSearchFilter?}&exactTerms={exactTerms?}&excludeTerms={excludeTerms?}&linkSite={linkSite?}&orTerms={orTerms?}&relatedSite={relatedSite?}&dateRestrict={dateRestrict?}&lowRange={lowRange?}&highRange={highRange?}&searchType={searchType}&fileType={fileType?}&rights={rights?}&imgSize={imgSize?}&imgType={imgType?}&imgColorType={imgColorType?}&imgDominantColor={imgDominantColor?}&alt=json"
  },
  "queries": {
    "request": [
      {
        "title": "Google Custom Search - ratatouille",
        "totalResults": "664000000",
        "searchTerms": "ratatouille",
        "count": 10,
        "startIndex": 1,
        "inputEncoding": "utf8",
        "outputEncoding": "utf8",
        "safe": "off",
        "cx": "d3adb34127ae42013",
        "searchType": "image"
      }
    ],
    "nextPage": [
      {
        "title": "Google Custom Search - ratatouille",
        "totalResults": "664000000",
        "searchTerms": "ratatouille",
        "count": 10,
        "startIndex": 11,
        "inputEncoding": "utf8",
        "outputEncoding": "utf8",
        "safe": "off",
        "cx": "d3adb34127ae42013",
        "searchType": "image"
      }
    ]
  },
  "context": {
    "title": "search"
  },
  "searchInformation": {
    "searchTime": 1.010972,
    "formattedSearchTime": "1.01",
    "totalResults": "664000000",
    "formattedTotalResults": "664,000,000"
  },
  "items": [
    {
      "kind": "customsearch#result",
      "title": "Ratatouille - Once Upon a Chef",
      "htmlTitle": "\u003cb\u003eRatatouille\u003c/b\u003e - Once Upon a Chef",
      "link": "https://www.onceuponachef.com/images/2017/07/Ratatouille-15.jpg",
      "displayLink": "www.onceuponachef.com",
      "snippet": "Ratatouille - Once Upon a Chef",
      "htmlSnippet": "\u003cb\u003eRatatouille\u003c/b\u003e - Once Upon a Chef",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.onceuponachef.com/recipes/ratatouille.html",
        "height": 3200,
        "width": 2149,
        "byteSize": 5352217,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlMssAJ8T4ySKkcQSE7QFtHA9FXQx_NUfILacs4aJXAWhiuj6KXeZ2_Q&s",
        "thumbnailHeight": 150,
        "thumbnailWidth": 101
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Ratatouille Recipe by Tasty",
      "htmlTitle": "\u003cb\u003eRatatouille\u003c/b\u003e Recipe by Tasty",
      "link": "https://img.buzzfeed.com/video-api-prod/assets/eb44570519264864814264f7f0a5e47a/BFV13909_BakedRatatouille-ThumbTextless1080.jpg?output-format=auto&output-quality=auto&resize=600:*",
      "displayLink": "tasty.co",
      "snippet": "Ratatouille Recipe by Tasty",
      "htmlSnippet": "\u003cb\u003eRatatouille\u003c/b\u003e Recipe by Tasty",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://tasty.co/recipe/ratatouille",
        "height": 600,
        "width": 600,
        "byteSize": 85823,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRNjEZ5zZwvVaXBrVR2KMdh76BtmhvztXF7R4AOlTcA2KLp7avK2EKafj08&s",
        "thumbnailHeight": 135,
        "thumbnailWidth": 135
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Ratatouille Recipe | ChefDeHome.com",
      "htmlTitle": "\u003cb\u003eRatatouille\u003c/b\u003e Recipe | ChefDeHome.com",
      "link": "https://media.chefdehome.com/740/0/0/ratatouille/ratatouille-casserole.jpg",
      "displayLink": "www.chefdehome.com",
      "snippet": "Ratatouille Recipe | ChefDeHome.com",
      "htmlSnippet": "\u003cb\u003eRatatouille\u003c/b\u003e Recipe | ChefDeHome.com",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.chefdehome.com/recipes/561/ratatouille",
        "height": 1069,
        "width": 740,
        "byteSize": 154795,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTcA0cBM36wCQPa36S6ojoe-kFk238vXd7GyMbMPMZCSJsQbrbvdqPP5g&s",
        "thumbnailHeight": 150,
        "thumbnailWidth": 104
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Ratatouille Pasta Recipe | Bon Appétit",
      "htmlTitle": "\u003cb\u003eRatatouille\u003c/b\u003e Pasta Recipe | Bon Appétit",
      "link": "https://assets.bonappetit.com/photos/5d4356436f98a4000898782b/5:4/w_3165,h_2532,c_limit/Basically-Ratatouille-Pasta.jpg",
      "displayLink": "www.bonappetit.com",
      "snippet": "Ratatouille Pasta Recipe | Bon Appétit",
      "htmlSnippet": "\u003cb\u003eRatatouille\u003c/b\u003e Pasta Recipe | Bon Appétit",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.bonappetit.com/recipe/ratatouille-pasta",
        "height": 2532,
        "width": 3165,
        "byteSize": 1106514,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRedpWeIGEFkIUskGlzBCKOsT1NNgeTalOBbrNGZcadj3vMVJXiGYtyAw&s",
        "thumbnailHeight": 120,
        "thumbnailWidth": 150
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Ratatouille - Once Upon a Chef",
      "htmlTitle": "\u003cb\u003eRatatouille\u003c/b\u003e - Once Upon a Chef",
      "link": "https://i0.wp.com/www.onceuponachef.com/images/2017/07/Ratatouille-15.jpg?resize=760%2C1132&ssl=1",
      "displayLink": "www.onceuponachef.com",
      "snippet": "Ratatouille - Once Upon a Chef",
      "htmlSnippet": "\u003cb\u003eRatatouille\u003c/b\u003e - Once Upon a Chef",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.onceuponachef.com/recipes/ratatouille.html",
        "height": 1132,
        "width": 760,
        "byteSize": 242761,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRG6hxkCHSUs7FEOfWBrZLSUk1LbCOIiSFwvLyAQLvaBNPxZsx6bUuOTyQ&s",
        "thumbnailHeight": 150,
        "thumbnailWidth": 101
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Oven Roasted Ratatouille - Budget Bytes",
      "htmlTitle": "Oven Roasted \u003cb\u003eRatatouille\u003c/b\u003e - Budget Bytes",
      "link": "https://www.budgetbytes.com/wp-content/uploads/2014/05/Oven-Roasted-Ratatouille-scoop.jpg",
      "displayLink": "www.budgetbytes.com",
      "snippet": "Oven Roasted Ratatouille - Budget Bytes",
      "htmlSnippet": "Oven Roasted \u003cb\u003eRatatouille\u003c/b\u003e - Budget Bytes",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.budgetbytes.com/oven-roasted-ratatouille/",
        "height": 900,
        "width": 1200,
        "byteSize": 91429,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSt539bS1fuWDJswuLX_sT4L97ihEVT1IHp3LMa4rCibMH44lyz3-GSBg&s",
        "thumbnailHeight": 113,
        "thumbnailWidth": 150
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Easy One-Pot Ratatouille Recipe - Classic French Vegan + Gluten Free",
      "htmlTitle": "Easy One-Pot \u003cb\u003eRatatouille\u003c/b\u003e Recipe - Classic French Vegan + Gluten Free",
      "link": "https://www.baconismagic.ca/wp-content/uploads/2015/12/ratatouille-720x720.jpg",
      "displayLink": "www.baconismagic.ca",
      "snippet": "Easy One-Pot Ratatouille Recipe - Classic French Vegan + Gluten Free",
      "htmlSnippet": "Easy One-Pot \u003cb\u003eRatatouille\u003c/b\u003e Recipe - Classic French Vegan + Gluten Free",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.baconismagic.ca/food/ratatouille-recipe/",
        "height": 720,
        "width": 720,
        "byteSize": 157236,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSz9tAt1QGm5-xJPQexINuMg0SjbEK8AMMPVJ7u2lzQ2UWneTYzA3Woia8&s",
        "thumbnailHeight": 140,
        "thumbnailWidth": 140
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Homemade Ratatouille Recipe (Step-by-step Video) | How To Cook.Recipes",
      "htmlTitle": "Homemade \u003cb\u003eRatatouille\u003c/b\u003e Recipe (Step-by-step Video) | How To Cook.Recipes",
      "link": "https://www.howtocook.recipes/wp-content/uploads/2021/05/Ratatouille-recipe-500x500.jpg",
      "displayLink": "www.howtocook.recipes",
      "snippet": "Homemade Ratatouille Recipe (Step-by-step Video) | How To Cook.Recipes",
      "htmlSnippet": "Homemade \u003cb\u003eRatatouille\u003c/b\u003e Recipe (Step-by-step Video) | How To Cook.Recipes",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.howtocook.recipes/homemade-ratatouille-recipe/",
        "height": 500,
        "width": 500,
        "byteSize": 149126,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSMsbXPOhNsuzDBOtDWF37D5S_YgZmgBZu_lQGXiVvpATKI4TzMwtS9j-Dn&s",
        "thumbnailHeight": 130,
        "thumbnailWidth": 130
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Best Ratatouille Recipe - Cookie and Kate",
      "htmlTitle": "Best \u003cb\u003eRatatouille\u003c/b\u003e Recipe - Cookie and Kate",
      "link": "https://cookieandkate.com/images/2019/09/best-ratatouille-recipe-1-1.jpg",
      "displayLink": "cookieandkate.com",
      "snippet": "Best Ratatouille Recipe - Cookie and Kate",
      "htmlSnippet": "Best \u003cb\u003eRatatouille\u003c/b\u003e Recipe - Cookie and Kate",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://cookieandkate.com/best-ratatouille-recipe/",
        "height": 1653,
        "width": 1100,
        "byteSize": 270640,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTVTfvGHj7_9-2rj_3Dbm25oxdbN99h8rJ-Y55N9uGDuV4W6C85Kpt72cM&s",
        "thumbnailHeight": 150,
        "thumbnailWidth": 100
      }
    },
    {
      "kind": "customsearch#result",
      "title": "Ratatouille (Tian Provençal) | Live Eat Learn",
      "htmlTitle": "\u003cb\u003eRatatouille\u003c/b\u003e (Tian Provençal) | Live Eat Learn",
      "link": "https://www.liveeatlearn.com/wp-content/uploads/2017/01/ratatouille-vegetable-tian-6.jpg",
      "displayLink": "www.liveeatlearn.com",
      "snippet": "Ratatouille (Tian Provençal) | Live Eat Learn",
      "htmlSnippet": "\u003cb\u003eRatatouille\u003c/b\u003e (Tian Provençal) | Live Eat Learn",
      "mime": "image/jpeg",
      "fileFormat": "image/jpeg",
      "image": {
        "contextLink": "https://www.liveeatlearn.com/1-pan-vegan-ratatouille/",
        "height": 1571,
        "width": 1200,
        "byteSize": 356301,
        "thumbnailLink": "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSlBs6dgCFvBR8LY9TTQvmyVffQvOdxyI2TSOCIM4cjbYRIRF9gGXfBjw&s",
        "thumbnailHeight": 150,
        "thumbnailWidth": 115
      }
    }
  ]
}

*/