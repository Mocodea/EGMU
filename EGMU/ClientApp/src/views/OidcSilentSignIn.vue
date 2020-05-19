<template>
  <div></div>
</template>

<script>
import { vuexOidcProcessSilentSignInCallback } from "vuex-oidc";

export default {
  name: "OidcSilentSignIn",
  created() {
    console.log("Silent Signin started.");
    vuexOidcProcessSilentSignInCallback();
  }
};
</script>