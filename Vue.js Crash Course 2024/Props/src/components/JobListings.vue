<script setup>
    import jobData from '@/jobs.json';
    import { ref } from 'vue';
    import JobListing from './JobListing.vue';

    const jobs = ref(jobData.jobs);
</script>

<template>
    <JobListing v-for="job in jobs" :key="job.id" :job="job" />
</template>
