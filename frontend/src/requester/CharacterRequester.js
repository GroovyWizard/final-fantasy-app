import axios from "axios";

class CharacterRequester {

  static async get() {
    var posts = null;
    await axios
      .get(`https://localhost:7022/character`)
      .then((response) => {
        posts = response.data;
      })
      .catch((error) => {
        console.log(error);
      });
    
      return posts
  }
}

export default CharacterRequester;