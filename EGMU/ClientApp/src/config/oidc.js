export const oidcSettings = {
  authority: process.env.VUE_APP_OIDC_AUTHORITY,
  client_id: 'EGMU',
  redirect_uri: process.env.VUE_APP_OIDC_REDIRECT_URI,
  response_type: 'code',
  scope: 'EGMUAPI openid profile',
  silentRedirectUri: process.env.VUE_APP_OIDC_SILENT_REDIRECT_URI,
  automaticSilentRenew: true, // If true oidc-client will try to renew your token when it is about to expire
};
